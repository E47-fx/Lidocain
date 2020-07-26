/*
 * FILE: WebMAN.cs
 * 
 * Original Author: E-47
 * Description: C# library that is compatible to WebMAN Mod, it also has compatibility to extended features of WebMAN
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Lidocain
{
    public class WebMAN
    {
        public static IPAddress IP;
        private static Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static WebClient cl = new WebClient();
        private static bool Parsed = false;

        public enum Port
        {
            CCAPI = 6333,
            PS3MAPI = 7887
        }

        public static bool ConnectTarget(string ipAddress, Port port)
        {
            try
            {
                if (IPAddress.TryParse(ipAddress, out IP))
                {
                    Parsed = true;
                    sock.Connect(IP, (int)port);
                    if (sock.Connected)
                        return true;
                    else
                    {
                        Parsed = false;
                        IP = null;
                        return false;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public enum DumpFile
        {
            LV1,
            LV2,
            RSX,
            FullMemory
        }

        public static int Dump(DumpFile file)
        {
            if (file == DumpFile.LV1)
                return cl.DownloadString("http://" + IP + "/dump.ps3?lv1").Contains("Dumped: dump_lv1.bin") ? 0 : -1;
            else if(file == DumpFile.LV2)
                return cl.DownloadString("http://" + IP + "/dump.ps3?lv2").Contains("Dumped: dump_lv2.bin") ? 0 : -1;
            else if(file == DumpFile.RSX)
                return cl.DownloadString("http://" + IP + "/dump.ps3?rsx").Contains("Dumped: dump_rsx.bin") ? 0 : -1;
            else if(file == DumpFile.FullMemory)
                return cl.DownloadString("http://" + IP + "/dump.ps3?full").Contains("Dumped: dump_full.bin") ? 0 : -1;
            return -1;
        }
        public static int Dump(ulong StartAddress, int megabytes)
        {
            if (megabytes > 256)
                return -1;
            return cl.DownloadString("http://" + IP + "/dump.ps3?" + StartAddress.ToString("X8") + "&size=" + megabytes).Contains("Dumped: dump_full.bin") ? 0 : -1;
        }

        public static int DisconnectTarget()
        {
            if (sock.Connected)
            {
                Parsed = false;
                sock.Disconnect(false);
                return sock.Connected ? -1 : 0;
            }
            return -1;
        }

        public static int RingBuzzer(int param1, int param2)
        {
            try
            {
                return SystemCalls.System_Call_3(392, 0x1004, param1, param2);
            }
            catch
            {
                return -1;
            }
        }

        public static void RenameFile(string file, string destination)
        {
            try
            {
                cl.DownloadString("http://" + IP + "/rename.ps3" + file + "&to=" + destination);
            }
            catch
            {

            }
        }

        public enum PowerFlag
        {
            QuickReboot,
            SoftReboot,
            HardReboot,
            DefaultReboot, // This is dependant on the settings of webman, as example if softreboot is the default reboot method, webman calls the softreboot function.
            VSH, // Reboots with the VSH command
            Shutdown
        }

        public static int Power(PowerFlag flag, out string RESULT)
        {
            try
            {
                string f = string.Empty;
                switch (flag)
                {
                    case PowerFlag.HardReboot:
                        f = cl.DownloadString("http://" + IP + "/reboot.ps3?hard");
                        if (f.Contains("reboot.ps3?hard : OK"))
                        {
                            RESULT = "REBOOT HARD : OK";
                            return 0;
                        }
                        break;
                    case PowerFlag.QuickReboot:
                        f = cl.DownloadString("http://" + IP + "/reboot.ps3?quick");
                        if (f.Contains("reboot.ps3?quick : OK"))
                        {
                            RESULT = "REBOOT QUICK : OK";
                            return 0;
                        }
                        break;
                    case PowerFlag.Shutdown:
                        f = cl.DownloadString("http://" + IP + "/shutdown.ps3");
                        if (f.Contains("shutdown.ps3 : OK"))
                        {
                            RESULT = "SHUTDOWN : OK";
                            return 0;
                        }
                        break;
                    case PowerFlag.SoftReboot:
                        f = cl.DownloadString("http://" + IP + "/reboot.ps3?soft");
                        if (f.Contains("reboot.ps3?soft : OK"))
                        {
                            RESULT = "REBOOT SOFT : OK";
                            return 0;
                        }
                        break;
                    case PowerFlag.VSH:
                        f = cl.DownloadString("http://" + IP + "/reboot.ps3?hard");
                        if (f.Contains("reboot.ps3?vsh : OK"))
                        {
                            RESULT = "REBOOT VSH : OK";
                            return 0;
                        }
                        break;
                }
                RESULT = "COMMAND : FAILED";
                return -1;
            }
            catch
            {
                RESULT = "COMMAND : FAILED TO CALL COMMAND";
                return -1;
            }
        }

        public struct Button
        {
            public static string Up
            {
                get { return "up"; }
            }
            public static string Down
            {
                get { return "down"; }
            }
            public static string Left
            {
                get { return "left"; }
            }
            public static string Right
            {
                get { return "right"; }
            }
            public static string Cross
            {
                get { return "cross"; }
            }
            public static string Circle
            {
                get { return "circle"; }
            }
            public static string Square
            {
                get { return "square"; }
            }
            public static string Triangle
            {
                get { return "triangle"; }
            }
            public static string L1
            {
                get { return "l1"; }
            }
            public static string L2
            {
                get { return "l2"; }
            }
            public static string R1
            {
                get { return "r1"; }
            }
            public static string R2
            {
                get { return "r2"; }
            }
            public static string PSButton
            {
                get { return "psbtn"; }
            }

            public static string AnalogLR
            {
                get { return "analogL_right"; }
            }

            public static string AnalogLL
            {
                get { return "analogL_left"; }
            }

            public static string AnalogLU
            {
                get { return "analogL_up"; }
            }

            public static string AnalogLD
            {
                get { return "analogL_down"; }
            }

            public static string AnalogRR
            {
                get { return "analogR_right"; }
            }

            public static string AnalogRL
            {
                get { return "analogR_left"; }
            }

            public static string AnalogRU
            {
                get { return "analogR_up"; }
            }

            public static string AnalogRD
            {
                get { return "analogR_down"; }
            }
        }

        public static int PressButton(string btn)
        {
            return (cl.DownloadString("http://" + IP + "/pad.ps3?" + btn).Contains(btn) ? 0 : -1);
        }

        public static void ToggleVSH()
        {
            cl.DownloadString("http://" + IP + "/browser.ps3$vsh_menu");
        }

        public static void ToggleSLaunch()
        {
            cl.DownloadString("http://" + IP + "/browser.ps3$slaunch");
        }

        public enum RSXMode
        {
            Paused,
            Operating
        }

        public enum MountMode
        {
            MountPartition,
            UnmountPartition
        }
        public static int MountDevBlind(MountMode mode)
        {
            if (mode == MountMode.MountPartition)
                return cl.DownloadString("http://" + IP + "/dev_blind?1").Contains("/dev_blind: ") ? 0 : -1;
            else if (mode == MountMode.UnmountPartition)
                return cl.DownloadString("http://" + IP + "/dev_blind?0").Contains("/dev_blind: ") ? 0 : -1;
            else return -1;
        }

        public static int SetRSXState(RSXMode mode)
        {
            switch (mode)
            {
                case RSXMode.Operating: return cl.DownloadString("http://" + IP + "/browser.ps3$rsx_continue").Contains("rsx_continue") ? 0 : -1;
                case RSXMode.Paused: return cl.DownloadString("http://" + IP + "/browser.ps3$rsx_pause").Contains("rsx_pause") ? 0 : -1;
                default: return -1;
            }

        }

        public static int DisableSyscalls(bool keepCCAPI)
        {
            if (!keepCCAPI)
                return cl.DownloadString("http://" + IP + "/browser.ps3$disable_syscalls").Contains("disable_syscalls") ? 0 : -1;
            return cl.DownloadString("http://" + IP + "/browser.ps3$disable_syscalls").Contains("disable_syscalls?ccapi") ? 0 : -1;
        }

        public static int RebuildDatabase()
        {
            string m = cl.DownloadString("http://" + IP + "/rebuild.ps3");
            if (m.Contains("rebuild.ps3 : OK"))
                return 0;
            return -1;
        }

        public static int Notify(string message)
        {
            string f = cl.DownloadString("http://" + IP + "/notify.ps3mapi?msg=" + message);
            if (f.Contains(message.Remove(4)))
                return 0;
            return -1;

        }

        public enum LedColor
        {
            Red = 0,
            Green = 1,
            Yellow = 2
        }

        public static int LoadPlugin(int slot, string path)
        {
            return cl.DownloadString("http://" + IP + "/vshplugin.ps3mapi?prx=" + path.ToString() + "&load_slot=" + slot.ToString()).Contains(path) ? 0 : 1;
        }

        public static int RecoveryNOR()
        {
            return cl.DownloadString("http://" + IP + "/recovery.ps3").Contains("recovery.ps3 : OK") ? 0 : 1;
        }

        public enum LedMode
        {
            Off = 0,
            On = 1,
            BlinkFast = 2,
            BlinkSlow = 3
        }

        public static int SetConsoleLed(LedColor color, LedMode mode)
        {
            return SystemCalls.System_Call_2(386, (int)color, (int)mode);
        }

        public static int SetFanSpeed(int speed)
        {
            return cl.DownloadString("http://" + IP + "/cpursx.ps3?fan=" + speed.ToString()).Contains(speed.ToString()) ? 0 : -1;
        }

        public enum LVType
        {
            LV1,
            LV2
        }

        public enum SC8Mode
        {
            FullyEnabled = 0,
            PartialEnabled_1 = 1,
            PartialEnabled_2 = 2,
            KeepLV1PeekOnly = 5,
            FakeDisabled = 3,
            Disabled = 4
        }

        /// <summary>
        /// Returns true when the connected console is a console that is running by HEN instead of CFW
        /// </summary>
        /// <returns></returns>
        public static bool isHEN()
        {
            return cl.DownloadString("http://" + IP + "/syscall.ps3?8|0x1337").Contains("syscall1(8) => 0x1337");
        }

        public static int SetSystemCall8Mode(SC8Mode mode)
        {
            char p = '"';
            if (mode == SC8Mode.FullyEnabled)
                return cl.DownloadString("http://" + IP + "/syscall8.ps3mapi?mode=0").Contains("<input type=" + Convert.ToString(p) + "radio" + Convert.ToString(p) + " name=" + Convert.ToString(p) + "mode" + Convert.ToString(p) + " value=" + Convert.ToString(p) + "0" + Convert.ToString(p) + " id=" + Convert.ToString(p) + "sc8_0" + Convert.ToString(p) + " checked=" + Convert.ToString(p) + "checked" + Convert.ToString(p) + "/>") ? 0 : -1;
            else if (mode == SC8Mode.PartialEnabled_1)
                return cl.DownloadString("http://" + IP + "/syscall8.ps3mapi?mode=1").Contains("<input type=" + Convert.ToString(p) + "radio" + Convert.ToString(p) + " name=" + Convert.ToString(p) + "mode" + Convert.ToString(p) + " value=" + Convert.ToString(p) + "1" + Convert.ToString(p) + " id=" + Convert.ToString(p) + "sc8_1" + Convert.ToString(p) + " checked=" + Convert.ToString(p) + "checked" + Convert.ToString(p) + "/>") ? 0 : -1;
            else if (mode == SC8Mode.PartialEnabled_2)
                return cl.DownloadString("http://" + IP + "/syscall8.ps3mapi?mode=2").Contains("<input type=" + Convert.ToString(p) + "radio" + Convert.ToString(p) + " name=" + Convert.ToString(p) + "mode" + Convert.ToString(p) + " value=" + Convert.ToString(p) + "2" + Convert.ToString(p) + " id=" + Convert.ToString(p) + "sc8_2" + Convert.ToString(p) + " checked=" + Convert.ToString(p) + "checked" + Convert.ToString(p) + "/>") ? 0 : -1;
            else if (mode == SC8Mode.FakeDisabled)
                return cl.DownloadString("http://" + IP + "/syscall8.ps3mapi?mode=3").Contains("<input type=" + Convert.ToString(p) + "radio" + Convert.ToString(p) + " name=" + Convert.ToString(p) + "mode" + Convert.ToString(p) + " value=" + Convert.ToString(p) + "3" + Convert.ToString(p) + " id=" + Convert.ToString(p) + "sc8_3" + Convert.ToString(p) + " checked=" + Convert.ToString(p) + "checked" + Convert.ToString(p) + "/>") ? 0 : -1;
            else if (mode == SC8Mode.Disabled)
                return cl.DownloadString("http://" + IP + "/syscall8.ps3mapi?mode=4").Contains("<input type=" + Convert.ToString(p) + "radio" + Convert.ToString(p) + " name=" + Convert.ToString(p) + "mode" + Convert.ToString(p) + " value=" + Convert.ToString(p) + "4" + Convert.ToString(p) + " id=" + Convert.ToString(p) + "sc8_4" + Convert.ToString(p) + " checked=" + Convert.ToString(p) + "checked" + Convert.ToString(p) + "/>") ? 0 : -1;
            else if (mode == SC8Mode.KeepLV1PeekOnly)
                return cl.DownloadString("http://" + IP + "/syscall8.ps3mapi?mode=5").Contains("<input type=" + Convert.ToString(p) + "radio" + Convert.ToString(p) + " name=" + Convert.ToString(p) + "mode" + Convert.ToString(p) + " value=" + Convert.ToString(p) + "5" + Convert.ToString(p) + " id=" + Convert.ToString(p) + "sc8_5" + Convert.ToString(p) + " checked=" + Convert.ToString(p) + "checked" + Convert.ToString(p) + "/>") ? 0 : -1;
            else return -1;
        }

        public static int OpenBrowserUrl(string url)
        {
            return cl.DownloadString("http://" + IP + "/browser.ps3?http://" + url + "/").Contains("http://" + url + "/") ? 0 : -1;
        }

        public enum MenuMode
        {
            Normal,
            REBUG
        }
        public static int SetSystemMode(MenuMode mode)
        {
            switch (mode)
            {
                case MenuMode.REBUG: return cl.DownloadString("http://" + IP + "/browser.ps3$toggle_rebug_mode").Contains("toggle_rebug_mode") ? 0 : -1;
                case MenuMode.Normal: return cl.DownloadString("http://" + IP + "/browser.ps3$toggle_normal_mode").Contains("toggle_normal_mode") ? 0 : -1;
                default: return -1;
            }

        }
        public static void ToggleCobra()
        {
            cl.DownloadString("http://" + IP + "/browser.ps3$toggle_cobra");
        }

        public static void TogglePS2Emu()
        {
            cl.DownloadString("http://" + IP + "/browser.ps3$toggle_ps2emu");
        }

        public static int ToggleDebugMenu()
        {
            return cl.DownloadString("http://" + IP + "/browser.ps3$toggle_debug_menu").Contains("toggle_debug_menu") ? 0 : -1;
        }

        public enum Endianness
        {
            [Obsolete("Little Endianness on the PS3 has not many uses. Consider using Big Endianness")]
            LittleEndian,
            BigEndian
        }

        public static void Poke(ulong Offset, byte[] buffer, int size, LVType type, Endianness endian = Endianness.BigEndian)
        {
            byte[] array = buffer;

            if (endian == Endianness.LittleEndian)
                Array.Reverse(array, 0, size);

            if (type == LVType.LV1)
                cl.DownloadString("http://" + IP + "/poke.lv2?" + Offset.ToString("X8") + "=" + BitConverter.ToString(array, 0, size).Replace("-", ""));
            else cl.DownloadString("http://" + IP + "/poke.lv1?" + Offset.ToString("X8") + "=" + BitConverter.ToString(array, 0, size).Replace("-", ""));
        }

        public static class SystemCalls
        {
            public static bool CheckSyscall(int num)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?8|0x7777|0x00091|" + num.ToString()).Contains("syscall3(8) => 0x0");
            }

            public static int DisableSyscall(int num)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?8|0x7777|0x00092|" + num.ToString()).Contains("syscall3(8) => 0x0") ? 0 : -1;
            }


            public static int CallSyscall(int num, string param, int amount)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + param).Contains("syscall" + amount.ToString() + "(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }


            public static int System_Call_0(int num)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString()).Contains("syscall0(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }

            public static int System_Call_1(int num, object param)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + "|" + param.ToString()).Contains("syscall1(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }

            public static int System_Call_2(int num, object param1, object param2)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + "|" + param1.ToString() + "|" + param2.ToString()).Contains("syscall2(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }

            public static int System_Call_3(int num, object param1, object param2, object param3)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + "|" + param1.ToString() + "|" + param2.ToString() + "|" + param3.ToString()).Contains("syscall3(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }

            public static int System_Call_4(int num, object param1, object param2, object param3, object param4)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + "|" + param1.ToString() + "|" + param2.ToString() + "|" + param3.ToString() + "|" + param4.ToString()).Contains("syscall4(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }

            public static int System_Call_5(int num, object param1, object param2, object param3, object param4, object param5)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + "|" + param1.ToString() + "|" + param2.ToString() + "|" + param3.ToString() + "|" + param4.ToString() + "|" + param5.ToString()).Contains("syscall5(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }

            public static int System_Call_6(int num, object param1, object param2, object param3, object param4, object param5, object param6)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + "|" + param1.ToString() + "|" + param2.ToString() + "|" + param3.ToString() + "|" + param4.ToString() + "|" + param5.ToString() + "|" + param6.ToString()).Contains("syscall6(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }

            public static int System_Call_7(int num, object param1, object param2, object param3, object param4, object param5, object param6, object param7)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + "|" + param1.ToString() + "|" + param2.ToString() + "|" + param3.ToString() + "|" + param4.ToString() + "|" + param5.ToString() + "|" + param6.ToString() + "|" + param7.ToString()).Contains("syscall7(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }

            public static int System_Call_8(int num, object param1, object param2, object param3, object param4, object param5, object param6, object param7, object param8)
            {
                return cl.DownloadString("http://" + IP + "/syscall.ps3?" + num.ToString() + "|" + param1.ToString() + "|" + param2.ToString() + "|" + param3.ToString() + "|" + param4.ToString() + "|" + param5.ToString() + "|" + param6.ToString() + "|" + param7.ToString() + "|" + param8.ToString()).Contains("syscall8(" + num.ToString() + ") => 0x0") ? 0 : -1;
            }
        }
    }
}
