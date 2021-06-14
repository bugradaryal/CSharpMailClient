﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail
{
    public class mail_tut
    {
        public int id { get; set; }
        public string yollayan { get; set; }
        public DateTimeOffset tarih { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }
    }
    public class mail_bodyfile_tut
    {
        public int id { get; set; }
        public Byte[] alınan_mail_bodyfile { get; set; }
        public string alınan_mail_bodyfile_name { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    public class mail_attachment_tut
    {
        public int id { get; set; }
        public Byte[] alınan_mail_attachment { get; set; }
    }
}
