using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API {
    public static class Handler {
        static PlexusDBEntities db = new PlexusDBEntities();
        public static PlexusDBEntities DB { get => db; }
    }
}