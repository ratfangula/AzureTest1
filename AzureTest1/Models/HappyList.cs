using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AzureTest1.Models
{
    public class HappyList
    {
        //private List<BasicItemModel> _itemList;
        [Key]
        public int ListID { get; set; }
        public List<BasicItemModel> ListItems { get; set; }

        HappyList()
        {
            ListID = 0;
            ListItems = new List<BasicItemModel>();
            BasicItemModel item = new BasicItemModel();
            item.ItemID = 0;
            item.ItemName = "empty";
            item.ItemDescription = "To Be Removed";
            ListItems.Add(item);

        }
    }
}