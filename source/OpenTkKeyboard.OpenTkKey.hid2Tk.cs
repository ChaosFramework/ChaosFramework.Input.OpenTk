using OpenTK.Windowing.GraphicsLibraryFramework;
using SysCol = System.Collections.Generic;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
    {
        partial class Key
        {
            internal static readonly SysCol.Dictionary<HidUsage, OpenTK.Windowing.GraphicsLibraryFramework.Keys> hid2Tk = new SysCol.Dictionary<HidUsage, OpenTK.Windowing.GraphicsLibraryFramework.Keys>()
            {
                [HidUsage.ErrorRollOver] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.PostFail] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.ErrorUndefined] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.A] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.A,
                [HidUsage.B] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.B,
                [HidUsage.C] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.C,
                [HidUsage.D] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D,
                [HidUsage.E] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.E,
                [HidUsage.F] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F,
                [HidUsage.G] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.G,
                [HidUsage.H] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.H,
                [HidUsage.I] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.I,
                [HidUsage.J] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.J,
                [HidUsage.K] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.K,
                [HidUsage.L] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.L,
                [HidUsage.M] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.M,
                [HidUsage.N] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.N,
                [HidUsage.O] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.O,
                [HidUsage.P] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.P,
                [HidUsage.Q] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Q,
                [HidUsage.R] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.R,
                [HidUsage.S] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.S,
                [HidUsage.T] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.T,
                [HidUsage.U] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.U,
                [HidUsage.V] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.V,
                [HidUsage.W] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.W,
                [HidUsage.X] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.X,
                [HidUsage.Y] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Y,
                [HidUsage.Z] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Z,
                [HidUsage.D1] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D1,
                [HidUsage.D2] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D2,
                [HidUsage.D3] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D3,
                [HidUsage.D4] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D4,
                [HidUsage.D5] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D5,
                [HidUsage.D6] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D6,
                [HidUsage.D7] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D7,
                [HidUsage.D8] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D8,
                [HidUsage.D9] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D9,
                [HidUsage.D0] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.D0,
                [HidUsage.Enter] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Enter,
                [HidUsage.Escape] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Escape,
                [HidUsage.Backspace] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Backspace,
                [HidUsage.Tab] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Tab,
                [HidUsage.Space] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Space,
                [HidUsage.Minus] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Minus,
                [HidUsage.Equal] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Equal, // untested
                [HidUsage.LeftBracket] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.LeftBracket,
                [HidUsage.RightBracket] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.RightBracket,
                [HidUsage.Backslash] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Backslash,
                [HidUsage.Hash] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Semicolon] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Semicolon,
                [HidUsage.Quote] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Grave] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Comma] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Comma,
                [HidUsage.Period] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Period,
                [HidUsage.Slash] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Slash,
                [HidUsage.CapsLock] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.CapsLock,
                [HidUsage.F1] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F1,
                [HidUsage.F2] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F2,
                [HidUsage.F3] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F3,
                [HidUsage.F4] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F4,
                [HidUsage.F5] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F5,
                [HidUsage.F6] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F6,
                [HidUsage.F7] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F7,
                [HidUsage.F8] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F8,
                [HidUsage.F9] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F9,
                [HidUsage.F10] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F10,
                [HidUsage.F11] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F11,
                [HidUsage.F12] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F12,
                [HidUsage.PrintScreen] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.PrintScreen,  // Untested

                // OpenTk triggers OpenTK.Windowing.GraphicsLibraryFramework.Keys.Pause for both HidUsage.Pause and HidUsage.ScrollLock.
                // It seems it never raises OpenTK.Windowing.GraphicsLibraryFramework.Keys.ScrollLock.
                // We bind OpenTK.Windowing.GraphicsLibraryFramework.Keys.Pause to HidUsage.Pause.
                [HidUsage.ScrollLock] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.ScrollLock,
                [HidUsage.Pause] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Pause,

                [HidUsage.Insert] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Insert,
                [HidUsage.Home] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Home,
                [HidUsage.PageUp] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.PageUp,
                [HidUsage.Delete] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Delete,
                [HidUsage.End] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.End,
                [HidUsage.PageDown] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.PageDown,
                [HidUsage.ArrowRight] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Right,
                [HidUsage.ArrowLeft] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Left,
                [HidUsage.ArrowDown] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Down,
                [HidUsage.ArrowUp] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Up,
                [HidUsage.NumLock] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.NumLock,
                [HidUsage.KeypadDivide] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPadDivide,
                [HidUsage.KeypadMultiply] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPadMultiply,
                [HidUsage.KeypadMinus] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPadSubtract,
                [HidUsage.KeypadPlus] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPadAdd,
                [HidUsage.KeypadEnter] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPadEnter,
                [HidUsage.Keypad1] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad1,
                [HidUsage.Keypad2] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad2,
                [HidUsage.Keypad3] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad3,
                [HidUsage.Keypad4] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad4,
                [HidUsage.Keypad5] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad5,
                [HidUsage.Keypad6] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad6,
                [HidUsage.Keypad7] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad7,
                [HidUsage.Keypad8] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad8,
                [HidUsage.Keypad9] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad9,
                [HidUsage.Keypad0] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad0,
                [HidUsage.KeypadPeriod] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,

                // OpenTk triggers OpenTK.Windowing.GraphicsLibraryFramework.Keys.Comma for both HidUsage.NonUsBackslashAndPipe and HidUsage.Comma.
                // We bind it to HidUsage.Comma.
                [HidUsage.NonUsBackslashAndPipe] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,

                [HidUsage.Application] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.LeftSuper,// Untested
                [HidUsage.Power] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,        // Could this be OpenTK.Windowing.GraphicsLibraryFramework.Keys.Sleep?
                [HidUsage.KeypadEquals] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.F13] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F13,              // Untested
                [HidUsage.F14] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F14,              // Untested
                [HidUsage.F15] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F15,              // Untested
                [HidUsage.F16] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F16,              // Untested
                [HidUsage.F17] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F17,              // Untested
                [HidUsage.F18] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F18,              // Untested
                [HidUsage.F19] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F19,              // Untested
                [HidUsage.F20] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F20,              // Untested
                [HidUsage.F21] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F21,              // Untested
                [HidUsage.F22] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F22,              // Untested
                [HidUsage.F23] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F23,              // Untested
                [HidUsage.F24] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.F24,              // Untested
                [HidUsage.Execute] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Help] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Menu] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Menu,
                [HidUsage.Select] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Stop] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Again] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Undo] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Cut] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Copy] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Paste] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Find] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Mute] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.VolumeUp] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.VolumeDown] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.LockingCapsLock] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.LockingNumLock] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.LockingScrollLock] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadComma] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadEqualAS400] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International1] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International2] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International3] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International4] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International5] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International6] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International7] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International8] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.International9] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang1] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang2] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang3] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang4] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang5] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang6] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang7] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang8] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Lang9] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.AlternateErase] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.SysReq] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Cancel] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Clear] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Prior] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Return] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Separator] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Out] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Oper] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.ClearAgain] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.CrSel] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.ExSel] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                // A5-AF RESERVED
                [HidUsage.Keypad00] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.Keypad000] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.ThousandsSeparator] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.DecimalSeparator] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.CurrencyUnit] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.CurrencySubUnit] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadParenthesisLeft] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadParenthesisRight] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadBraceLeft] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadBraceRight] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadTab] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadBackspace] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadA] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadB] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadC] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadD] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadE] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadF] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadXor] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadLogicalAnd] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadPercent] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadLessThan] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadGreaterThan] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadAnd] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadAndAnd] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadOr] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadOrOr] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadColon] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadHash] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadSpace] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadAt] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadExclamation] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadMemoryStore] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadMemoryRecall] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadMemoryClear] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadMemoryAdd] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadMemorySubtract] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadMemoryMultiply] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadMemoryDivide] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadSign] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadClear] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadClearEntry] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadBinary] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadOctal] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadDecimal] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.KeypadHexadecimal] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                // DE-DF RESERVED
                [HidUsage.ControlLeft] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.LeftControl,
                [HidUsage.ShiftLeft] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.LeftShift,
                [HidUsage.AltLeft] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.LeftAlt,
                [HidUsage.GuiLeft] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                [HidUsage.ControlRight] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.RightControl,
                [HidUsage.ShiftRight] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.RightShift,
                [HidUsage.AltRight] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.RightAlt,
                [HidUsage.GuiRight] = OpenTK.Windowing.GraphicsLibraryFramework.Keys.Unknown,
                // E8-FFFF RESERVED
            };

            internal static readonly SysCol.Dictionary<OpenTK.Windowing.GraphicsLibraryFramework.Keys, HidUsage> tk2Hid = [];

            static Key()
            {
                SysCol.HashSet<OpenTK.Windowing.GraphicsLibraryFramework.Keys> seen = [];
                foreach(SysCol.KeyValuePair<HidUsage, OpenTK.Windowing.GraphicsLibraryFramework.Keys> kvp in hid2Tk)
                    if (seen.Add(kvp.Value))
                        tk2Hid[kvp.Value] = kvp.Key;
                    else
                        tk2Hid.Remove(kvp.Value);
            }
        }
    }
}
