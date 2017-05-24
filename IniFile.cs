using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace FaceUp
{
    class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport( "kernel32" )]
        static extern long WritePrivateProfileString ( string Section, string Key, string Value, string FilePath );

        [DllImport( "kernel32" )]
        static extern int GetPrivateProfileString ( string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath );

        public IniFile ( string IniPath = null )
        {
            Path = new FileInfo( IniPath ?? EXE + ".ini" ).FullName.ToString();
            //if (!File.Exists( IniPath ))
            //{
            //    Path = new FileInfo( IniPath ?? EXE + ".ini" ).FullName.ToString();
            //}
            //else Path = new FileInfo( IniPath ?? EXE + ".ini" ).FullName.ToString();
        }

        public string Read ( string Key, string Section = null )
        {
            try
            {
                var RetVal = new StringBuilder( 255 );
                GetPrivateProfileString( Section ?? EXE, Key, "", RetVal, 255, Path );
                return RetVal.ToString();
            }
            catch
            {
                FileError();
                return "-1";
            }
        }

        public void Write ( string Key, string Value, string Section = null )
        {
            try
            {
                WritePrivateProfileString( Section ?? EXE, Key, Value, Path );
            }
            catch
            {
                FileError();
            }
        }

        public void DeleteKey ( string Key, string Section = null )
        {
            try
            {
                Write( Key, null, Section ?? EXE );
            }
            catch
            {
                FileError();
            }
        }

        public void DeleteSection ( string Section = null )
        {
            try
            {
                Write( null, null, Section ?? EXE );
            }
            catch
            {
                FileError();
            }
        }

        public bool KeyExists ( string Key, string Section = null )
        {
            return Read( Key, Section ).Length > 0;
        }

        public void FileError ()
        {
            throw new Exception( "Error reading or writing INI file" );
        }
    }
}
