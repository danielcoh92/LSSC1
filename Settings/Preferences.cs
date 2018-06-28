using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSSC.Settings
{

    class Preferences
    {
        bool fullscreen = false;
        int resX = 800;
        int resY = 600;
        bool resizing = false;
        bool autosizing = true;
        String language = "en";

        public Preferences(bool fullscreen, int resX, int resY, bool resizing, bool autosizing, String language)
        {
            this.fullscreen = fullscreen;
            this.resX = resX;
            this.resY = resY;
            this.resizing = resizing;
            this.autosizing = autosizing;
            this.language = language;
        }

    }
}
