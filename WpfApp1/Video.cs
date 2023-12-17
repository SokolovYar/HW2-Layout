using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class Video
    {
        protected Image Image { get; set; }
        protected string Name { get; set; }
        protected string Author {  get; set; }
        protected string ? Description { get; set; }
        protected TimeOnly Duration { get; set; }
    }
}
