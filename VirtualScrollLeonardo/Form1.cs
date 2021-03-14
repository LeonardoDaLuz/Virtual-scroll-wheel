using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool controlPressedOnLastFrame;
        int OldMouseX;
        int OldMouseY;
        int MouseX;
        int MouseY;
        int refX;
        int refY;
        float DragIntensity = 1;
        float DragImpulse = 1;
        float SwipeIntensity = 1;

        public enum ScrollMovementType { None, Drag, Swipe }
        public ScrollMovementType LeftMouse;
        public ScrollMovementType RightMouse;
        public ScrollMovementType MiddleMouse;
        public ScrollMovementType Ctrl;
        public ScrollMovementType shift;
        public ScrollMovementType Alt;
        bool loaded=false;
        bool UseControlForNegateUseLeftClick = true;
        bool bypassRightClickContextMenu = true;
        bool bypassRightClickContextMenuNow = false;
        bool movedOnLastClickToDrag = false;
        float _msToForceBypass;
        string ConfigFile = @"\configuration.ini";

        int TimeDeadZoneToBypassContextMenu=30;
        int TimeDeadZoneToBypassContextMenuCounter;
        int VanishPointX;
        int VanishPointY;
        int StartPointX;
        int StartPointY;
        int EndPointX;
        int EndPointY;
        public int IncludedScreenPixels;

        bool globalDisabled=false;

        void LoadConfig()
        {
            Console.WriteLine("LoadConfig()");
            Console.WriteLine(@Application.StartupPath + ConfigFile);
            //string text = System.IO.File.ReadAllText(@Application.StartupPath+ConfigFile);
            string[] lines=new string[0];
            if (File.Exists(Application.StartupPath + ConfigFile)) {
                lines = System.IO.File.ReadAllLines(Application.StartupPath + ConfigFile);
                Console.WriteLine("NUMERO DE LINHAS ENCONTRADAS NO ARQUIVO ini: " + lines.Length);
                if (lines.Length != 19)
                {
                    LoadConfigDefault();
                    return;
                }

            }
            else
            {
                LoadConfigDefault();
                return;
            }
            
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("Control"))
                {
                    if (lines[i].Contains("None"))
                    {
                        comboBoxCtrl.SelectedItem = "None";
                        Ctrl = ScrollMovementType.None;
                    }
                    if (lines[i].Contains("Drag"))
                    {
                        comboBoxCtrl.SelectedItem = "Drag";
                        Ctrl = ScrollMovementType.Drag;
                    }
                    if (lines[i].Contains("Swipe"))
                    {
                        comboBoxCtrl.SelectedItem = "Swipe";
                        Ctrl = ScrollMovementType.Swipe;
                    }
                }
                if (lines[i].Contains("LeftClick"))
                {
                    if (lines[i].Contains("None"))
                    {
                        comboBoxLeftMouse.SelectedItem = "None";
                        LeftMouse = ScrollMovementType.None;
                    }
                    if (lines[i].Contains("Drag"))
                    {
                        comboBoxLeftMouse.SelectedItem = "Drag";
                        LeftMouse = ScrollMovementType.Drag;
                    }
                    if (lines[i].Contains("Swipe"))
                    {
                        comboBoxLeftMouse.SelectedItem = "Swipe";
                        LeftMouse = ScrollMovementType.Swipe;
                    }
                }
                if (lines[i].Contains("RightClick"))
                {
                    if (lines[i].Contains("None"))
                    {
                        comboBoxRightmouse.SelectedItem = "None";
                        RightMouse = ScrollMovementType.None;
                    }
                    if (lines[i].Contains("Drag"))
                    {
                        comboBoxRightmouse.SelectedItem = "Drag";
                        RightMouse = ScrollMovementType.Drag;
                    }
                    if (lines[i].Contains("Swipe"))
                    {
                        comboBoxRightmouse.SelectedItem = "Swipe";
                        RightMouse = ScrollMovementType.Swipe;
                    }
                }
                if (lines[i].Contains("MiddleClick"))
                {
                    if (lines[i].Contains("None"))
                    {
                        comboBoxMiddlemouse.SelectedItem = "None";
                        MiddleMouse = ScrollMovementType.None;
                    }
                    if (lines[i].Contains("Drag"))
                    {
                        comboBoxMiddlemouse.SelectedItem = "Drag";
                        MiddleMouse = ScrollMovementType.Drag;
                    }
                    if (lines[i].Contains("Swipe"))
                    {
                        comboBoxMiddlemouse.SelectedItem = "Swipe";
                        MiddleMouse = ScrollMovementType.Swipe;
                    }
                }
                if (lines[i].Contains("Alt"))
                {
                    if (lines[i].Contains("None"))
                    {
                        comboBoxAlt.SelectedItem = "None";
                        Alt = ScrollMovementType.None;
                    }
                    if (lines[i].Contains("Drag"))
                    {
                        comboBoxAlt.SelectedItem = "Drag";
                        Alt = ScrollMovementType.Drag;
                    }
                    if (lines[i].Contains("Swipe"))
                    {
                        comboBoxAlt.SelectedItem = "Swipe";
                        Alt = ScrollMovementType.Swipe;
                    }
                }
                if (lines[i].Contains("Shift"))
                {
                    if (lines[i].Contains("None"))
                    {
                        comboBoxShift.SelectedItem = "None";
                        shift = ScrollMovementType.None;
                    }
                    if (lines[i].Contains("Drag"))
                    {
                        comboBoxShift.SelectedItem = "Drag";
                        shift = ScrollMovementType.Drag;
                    }
                    if (lines[i].Contains("Swipe"))
                    {
                        comboBoxShift.SelectedItem = "Swipe";
                        shift = ScrollMovementType.Swipe;
                    }
                }
                if (lines[i].Contains("DragIntensity"))
                {
                    lines[i] = lines[i].Replace("DragIntensity", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");

                    DragIntensity = (float)Convert.ToDouble(lines[i]);
                    numericUpDownDragIntensity.Value = (int)(DragIntensity);
                }
                if (lines[i].Contains("DragImpulse"))
                {
                    lines[i] = lines[i].Replace("DragImpulse", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");

                    DragImpulse = (float)Convert.ToDouble(lines[i]);
                    numericUpDownDragImpulse.Value = (int)(DragImpulse);
                }
                if (lines[i].Contains("SwipeIntensity"))
                {
                    lines[i] = lines[i].Replace("SwipeIntensity", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");

                    SwipeIntensity = (float)Convert.ToDouble(lines[i]);
                    numericUpDownSwipe.Value = (int)(SwipeIntensity);
                }
                if (lines[i].Contains("MsToForceBypass"))
                {
                    lines[i] = lines[i].Replace("MsToForceBypass", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");
                    Console.WriteLine(lines[i]);
                    _msToForceBypass = (float)Convert.ToDouble(lines[i]);
                    MsToForceBypas.Value = (Decimal)(_msToForceBypass);
                }
                if (lines[i].Contains("UseControlForNegateUseLeftClick"))
                {
                    if (lines[i].Contains("True"))
                    {
                        CtrlDesactiveLeftMouseButton.CheckState = CheckState.Checked;
                        UseControlForNegateUseLeftClick = true;
                    }
                    else
                    {
                        CtrlDesactiveLeftMouseButton.CheckState = CheckState.Unchecked;
                        UseControlForNegateUseLeftClick = false;
                    }
                }
                if (lines[i].Contains("BypassRightClickContextMenu"))
                {
                    if (lines[i].Contains("True"))
                    {
                        BypassContextMenu.CheckState = CheckState.Checked;
                        bypassRightClickContextMenu = true;
                    }
                    else
                    {
                        BypassContextMenu.CheckState = CheckState.Unchecked;
                        bypassRightClickContextMenu = false;
                    }
                }
                if (lines[i].Contains("ByPassDeadZone"))
                {
                    lines[i] = lines[i].Replace("ByPassDeadZone", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");
                    Console.WriteLine(lines[i]);
                    TimeDeadZoneToBypassContextMenu = (int)Convert.ToDouble(lines[i]);
                    ByassContextMenuDeadZone.Value = (Decimal)(TimeDeadZoneToBypassContextMenu);
                }
                if (lines[i].Contains("VanishPointX"))
                {
                    lines[i] = lines[i].Replace("VanishPointX", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");
                    Console.WriteLine(lines[i]);
                    VanishPointX = (int)Convert.ToDouble(lines[i]);
                    VanishingPointX.Value = (Decimal)(VanishPointX);
                }
                if (lines[i].Contains("VanishPointY"))
                {
                    lines[i] = lines[i].Replace("VanishPointY", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");
                    Console.WriteLine(lines[i]);
                    VanishPointY = (int)Convert.ToDouble(lines[i]);
                    VanishingPointY.Value = (Decimal)(VanishPointY);
                }
                if (lines[i].Contains("StartPointX"))
                {
                    lines[i] = lines[i].Replace("StartPointX", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");
                    Console.WriteLine(lines[i]);
                    StartPointX = (int)Convert.ToDouble(lines[i]);
                    numericUpDownStartPointX.Value = (Decimal)(StartPointX);
                }
                if (lines[i].Contains("StartPointY"))
                {
                    lines[i] = lines[i].Replace("StartPointY", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");
                    Console.WriteLine(lines[i]);
                    StartPointY = (int)Convert.ToDouble(lines[i]);
                    numericUpDownStartPointY.Value = (Decimal)(StartPointY);
                }
                if (lines[i].Contains("EndPointX"))
                {
                    lines[i] = lines[i].Replace("EndPointX", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");
                    Console.WriteLine(lines[i]);
                    EndPointX = (int)Convert.ToDouble(lines[i]);
                    numericUpDownEndPointX.Value = (Decimal)(EndPointX);
                }
                if (lines[i].Contains("EndPointY"))
                {
                    lines[i] = lines[i].Replace("EndPointY", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("=", "");
                    Console.WriteLine(lines[i]);
                    EndPointY = (int)Convert.ToDouble(lines[i]);
                    numericUpDownEndPointY.Value = (Decimal)(EndPointY);
                }
            }
            
            Console.WriteLine("4()");
            // Keep the console window open in debug mode.
            loaded = true;

        }

        void LoadConfigDefault()
        {
            Console.WriteLine("CARREGANDO CONFIGURAÇÃO DEFAULT");
            Console.WriteLine(@Application.StartupPath + ConfigFile);
            
            comboBoxCtrl.SelectedItem = "None";
            Ctrl = ScrollMovementType.None;

            comboBoxLeftMouse.SelectedItem = "None";
            LeftMouse = ScrollMovementType.None;

            comboBoxRightmouse.SelectedItem = "Drag";
            RightMouse = ScrollMovementType.Drag;

            comboBoxMiddlemouse.SelectedItem = "Swipe";
            MiddleMouse = ScrollMovementType.Swipe;

            comboBoxAlt.SelectedItem = "Swipe";
            Alt = ScrollMovementType.Swipe;

            comboBoxShift.SelectedItem = "Swipe";
            shift = ScrollMovementType.Swipe;

            DragIntensity = 1000;
            numericUpDownDragIntensity.Value = 1000;

            DragImpulse = 1000;
            numericUpDownDragImpulse.Value = 1000;


            SwipeIntensity = 1000;
            numericUpDownSwipe.Value = 1000;

            UseControlForNegateUseLeftClick = true;
            CtrlDesactiveLeftMouseButton.CheckState = CheckState.Checked;

            BypassContextMenu.CheckState = CheckState.Checked;
            bypassRightClickContextMenu = true;
            // Keep the console window open in debug mode.
            _msToForceBypass = 16;
            MsToForceBypas.Value = 16;

            TimeDeadZoneToBypassContextMenu = 20;
            ByassContextMenuDeadZone.Value = 20;

            VanishPointX = 0;
            VanishingPointX.Value = 0;

            VanishPointY = 1080;
            VanishingPointY.Value = 1080;

            StartPointX = 0;
            StartPointY = 0;
            EndPointX = 9999;
            EndPointY = 9999;

            loaded = true;
            LoadConfigFromInterfaceAndSaveToFile();

        }
        void LoadConfigFromInterfaceAndSaveToFile()
        {
            if (loaded == false)
                return;
            Console.WriteLine("LoadConfigFromInterfaceAndSaveToFile()");
            Console.WriteLine(@Application.StartupPath + ConfigFile);
            //string text = System.IO.File.ReadAllText(@Application.StartupPath+ConfigFile);
            string[] lines = new string[19];

            if ((string)comboBoxCtrl.SelectedItem == "None")
            {
                lines[0] = "Control = None";
                Ctrl = ScrollMovementType.None;
            }
            if ((string)comboBoxCtrl.SelectedItem == "Drag")
            {
                lines[0] = "Control = Drag";
                Ctrl = ScrollMovementType.Drag;
            }
            if ((string)comboBoxCtrl.SelectedItem == "Swipe")
            {
                lines[0] = "Control = Swipe";
                Ctrl = ScrollMovementType.Swipe;
            }

            if ((string)comboBoxLeftMouse.SelectedItem == "None")
            {
                lines[1] = "LeftClick = None";
                LeftMouse = ScrollMovementType.None;
            }
            if ((string)comboBoxLeftMouse.SelectedItem == "Drag")
            {
                lines[1] = "LeftClick = Drag";
                LeftMouse = ScrollMovementType.Drag;
            }
            if ((string)comboBoxLeftMouse.SelectedItem == "Swipe")
            {
                lines[1] = "LeftClick = Swipe";
                LeftMouse = ScrollMovementType.Swipe;
            }


            if ((string)comboBoxRightmouse.SelectedItem == "None")
            {
                lines[2] = "RightClick = None";
                RightMouse = ScrollMovementType.None;
            }
            if ((string)comboBoxRightmouse.SelectedItem == "Drag")
            {
                lines[2] = "RightClick = Drag";
                RightMouse = ScrollMovementType.Drag;
            }
            if ((string)comboBoxRightmouse.SelectedItem == "Swipe")
            {
                lines[2] = "RightClick = Swipe";
                RightMouse = ScrollMovementType.Swipe;
            }


            if ((string)comboBoxMiddlemouse.SelectedItem == "None")
            {
                lines[3] = "MiddleClick = None";
                MiddleMouse = ScrollMovementType.None;
            }
            if ((string)comboBoxMiddlemouse.SelectedItem == "Drag")
            {
                lines[3] = "MiddleClick = Drag";
                MiddleMouse = ScrollMovementType.Drag;
            }
            if ((string)comboBoxMiddlemouse.SelectedItem == "Swipe")
            {
                lines[3] = "MiddleClick = Swipe";
                MiddleMouse = ScrollMovementType.Swipe;
            }

            if ((string)comboBoxAlt.SelectedItem == "None")
            {
                lines[4] = "Alt  = None";
                Alt = ScrollMovementType.None;
            }

            if ((string)comboBoxAlt.SelectedItem == "Drag")
            {
                lines[4] = "Alt  = Drag";
                Alt = ScrollMovementType.Drag;
            }
            if ((string)comboBoxAlt.SelectedItem == "Swipe")
            {
                lines[4] = "Alt  = Swipe";
                Alt = ScrollMovementType.Swipe;
            }

            if ((string)comboBoxShift.SelectedItem == "None")
            {
                lines[5] = "Shift = None";
                shift = ScrollMovementType.None;
            }
            if ((string)comboBoxShift.SelectedItem == "Drag")
            {
                lines[5] = "Shift = Drag";
                shift = ScrollMovementType.Drag;
            }
            if ((string)comboBoxShift.SelectedItem == "Swipe")
            {
                lines[5] = "Shift = Swipe";
                shift = ScrollMovementType.Swipe;
            }

            lines[6] = "DragIntensity = " + numericUpDownDragIntensity.Value;
            DragIntensity = (float)numericUpDownDragIntensity.Value;

            lines[7] = "DragImpulse = " + numericUpDownDragImpulse.Value;
            DragImpulse = (float)numericUpDownDragImpulse.Value;


            lines[11] = "MsToForceBypass = " + MsToForceBypas.Value;
            _msToForceBypass = (float)MsToForceBypas.Value;

            SwipeIntensity = (float)numericUpDownSwipe.Value;
            lines[8] = "SwipeIntensity = " + SwipeIntensity;


            UseControlForNegateUseLeftClick = CtrlDesactiveLeftMouseButton.CheckState == CheckState.Checked ? true : false;
            lines[9] = "UseControlForNegateUseLeftClick = " + UseControlForNegateUseLeftClick;

            bypassRightClickContextMenu = BypassContextMenu.CheckState == CheckState.Checked ? true : false;
            lines[10] = "BypassRightClickContextMenu =" + bypassRightClickContextMenu;

            TimeDeadZoneToBypassContextMenu = (int)ByassContextMenuDeadZone.Value;
            lines[12] = "ByPassDeadZone =" + TimeDeadZoneToBypassContextMenu;

            VanishPointX = (int)VanishingPointX.Value;
            lines[13] = "VanishPointX =" + VanishPointX;
            VanishPointY = (int)VanishingPointY.Value;
            lines[14] = "VanishPointY =" + VanishPointY;
            Console.WriteLine("Writed");
            StartPointX = (int)numericUpDownStartPointX.Value;
            lines[15] = "StartPointX =" + StartPointX;

            StartPointY = (int)numericUpDownStartPointY.Value;
            lines[16] = "StartPointY =" + StartPointY;

            EndPointX = (int)numericUpDownEndPointX.Value;
            lines[17] = "EndPointX =" + EndPointX;

            EndPointY = (int)numericUpDownEndPointY.Value;
            lines[18] = "EndPointY =" + EndPointY;

            Console.WriteLine("Salvou Configuração");
            System.IO.File.WriteAllLines(Application.StartupPath + ConfigFile, lines);

            Console.WriteLine("Writed");


            // Keep the console window open in debug mode.

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            BeginInvoke(new MethodInvoker(hideAll), 1f);
            LoadConfig();
            timer1.Start();
            timer1.Interval = 0016;

            timer1.Enabled = true;
            this.WindowState = FormWindowState.Minimized;
            Console.WriteLine("Form1_Load()");
        }
        void hideAll()
        {
            this.Hide();
        }
        //"Form Shown" event handler
        private void Form_Shown(object sender, EventArgs e)
        {
            //to minimize window
            this.WindowState = FormWindowState.Minimized;

            //to hide from taskbar
            this.Hide();
        }
        bool globalDisabledOnLastFrame;
        void CheckIfGoScroll()
        {
            Console.WriteLine("CheckIfGoScroll");
            if (Keyboard.IsKeyDown(Key.LeftAlt) && Keyboard.IsKeyDown(Key.LeftCtrl))
            { if (!globalDisabledOnLastFrame)
                {
                    globalDisabled = !globalDisabled;
                    globalDisabledOnLastFrame = true;
                }
            } else
            {
                globalDisabledOnLastFrame = false;
            }
                if (globalDisabled)
                return;
            if ((Control.MouseButtons & MouseButtons.Right) == MouseButtons.Right && !(UseControlForNegateUseLeftClick && Keyboard.IsKeyDown(Key.LeftCtrl)))
            {
                bypassRightClickContextMenuNow = true;
                GoScroll(RightMouse);
            }
            else if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left && !(UseControlForNegateUseLeftClick && Keyboard.IsKeyDown(Key.LeftCtrl)))
            {
                GoScroll(LeftMouse);
            }
            else if ((Control.MouseButtons & MouseButtons.Middle) == MouseButtons.Middle && !(UseControlForNegateUseLeftClick && Keyboard.IsKeyDown(Key.LeftCtrl)))
            {
                GoScroll(MiddleMouse);
            }
            else if (Keyboard.IsKeyDown(Key.LeftAlt))
            {
                GoScroll(Alt);
            }
            else if (Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                GoScroll(Ctrl);
            }
            else if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                GoScroll(shift);
            }
            else
            {
                GoScroll(ScrollMovementType.None);
            }
        }
        void GoScroll(ScrollMovementType type)
        {
            Console.WriteLine("GoScroll"+ type);
            //captura posição do mouse
            MouseManipulator.VirtualMouse.POINT mousePosition;

            if (MousePosition.X < StartPointX || MousePosition.X > EndPointX || MousePosition.Y < StartPointY || MousePosition.Y > EndPointY)
                return;

            MouseManipulator.VirtualMouse.GetCursorPos(out mousePosition);
            //faz backup da ultima posição do mouse, isto serve pra n causar delay de 1 frame entre clicar e  dar scrool, por isso ele considera a referencia do frame anterior
            OldMouseX = MouseX;
            OldMouseY = MouseY;
            //esss duas são as que indicam a posição do mouse no momento atual
            MouseX = mousePosition.X;
            MouseY = mousePosition.Y;

            //Verifica se esta pressionando as teclas necessarias pra fazer scrools
            if (type != ScrollMovementType.None)
            {
                if (!controlPressedOnLastFrame)
                {
                    refX = OldMouseX;
                    refY = OldMouseY;
                    controlPressedOnLastFrame = true;
                }

                float DiffX = (mousePosition.X - refX);
                float DiffY = (mousePosition.Y - refY);
                if(DiffX>-5 && DiffX<5 && DiffY<5 && DiffY > -5)
                {

                }
                else
                {
                    movedOnLastClickToDrag = true; //isso especifica q houve uma arrastada então dará o bypass no contextmenu
                    TimeDeadZoneToBypassContextMenuCounter = TimeDeadZoneToBypassContextMenu;
                }

                if (DiffY != 0f)
                {
                    if (type == ScrollMovementType.Swipe)
                    {
                        MouseManipulator.VirtualMouse.MiddleScroll(-(int)(DiffY * (SwipeIntensity * 0.001f)));

                    }
                    else
                    {
                        MouseManipulator.VirtualMouse.MiddleScroll((int)((MouseY - OldMouseY) * (DragIntensity * 0.001f)));
                    }
                } else
                {

                }
            }
            else
            {
                TimeDeadZoneToBypassContextMenuCounter--;

                if (controlPressedOnLastFrame && bypassRightClickContextMenuNow)
                {
                    if (TimeDeadZoneToBypassContextMenuCounter>0) //se moveu, faz o hack, caso contrario, ele ignora e deixa o context menu aparecer
                    {
                        int x= MouseX;
                        int y = MouseY;
                        System.Windows.Forms.Cursor.Position = new Point(VanishPointX, VanishPointY);

                        for (int i = 0; i < _msToForceBypass; i++)
                        {
                            System.Windows.Forms.Cursor.Position = new Point(VanishPointX, VanishPointY);
                            MouseManipulator.VirtualMouse.MiddleClick();
                            System.Threading.Thread.Sleep(1);
                        }
                        System.Windows.Forms.Cursor.Position = new Point(x, y);
                        movedOnLastClickToDrag = false;
                    }
                    bypassRightClickContextMenuNow = false;
                }
                controlPressedOnLastFrame = false;
            } // System.Threading.Thread.Sleep(16);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckIfGoScroll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void numericUpDownDragIntensity_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void comboBoxLeftMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void numericUpDownDragImpulse_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void numericUpDownSwipe_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void comboBoxRightmouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void comboBoxMiddlemouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void comboBoxCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void comboBoxAlt_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void comboBoxShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }


        private void Form1_ResizeBegin(object sender, EventArgs e)
        {

        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }
        private void notifyIcon1_DoubleClick(object sender,
                                     System.EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void MsToForceBypas_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void VanishingPoint_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void ByassContextMenuDeadZone_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void VanishingPointY_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownStartPointX_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void numericUpDownStartPointY_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void numericUpDownEndPointX_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }

        private void numericUpDownEndPointY_ValueChanged(object sender, EventArgs e)
        {
            LoadConfigFromInterfaceAndSaveToFile();
        }
    }
}


//essas classes peguei da net e editei, elas fazem a interface de uso com o mouse do sistema. OBS: se não funcionar tem q adicionar a referencia presentationcore
namespace MouseManipulator
{
    public static class VirtualMouse
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_WHEEL = 0x0800;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public static void Move(int xDelta, int yDelta)
        {

            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }
        public static void MoveTo(int x, int y)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
        }
        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void MiddleClick()
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_MIDDLEUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void MiddleClickDown()
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void LeftClickMouseUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void LeftDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }

        public static void LeftUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void RightClickUp()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void RightClickDown()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void RightDown()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }

        public static void RightUp()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        public static void MiddleScroll(int axis)
        {
            mouse_event(MOUSEEVENTF_WHEEL, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, axis, 0);

        }
    }
}