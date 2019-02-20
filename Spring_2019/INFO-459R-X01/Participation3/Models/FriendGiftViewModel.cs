using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Participation3.Models;

namespace Participation3.Models
{
    public class FriendGiftViewModel
    {
        public IEnumerable<Friend> Friends { get; set; }
        public IEnumerable<Gift> Gifts { get; set; }

    }
}