using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace mm
{
   
    class InfoTVS : UITableViewSource
    {
        public NSUserDefaults storevalues = new NSUserDefaults();
        List<Info> infos;
        public InfoTVS(List<Info> infos)
        {
            this.infos = infos;

        }

        //public override tableView(UITableView tableView, didSelectRowAt indexPath IndexPath)
        //{
        //    Console.WriteLine(indexPath.row);
        // }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            Console.WriteLine($"Long press on row, at {indexPath.Row}");
            storevalues.SetDouble(infos[indexPath.Row].Lat, "Latitude");
            storevalues.SetDouble(infos[indexPath.Row].Long, "Longitude");

        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (InfoCell)tableView.DequeueReusableCell("cell_id", indexPath);
            
            var info = infos[indexPath.Row];
            cell.UpdateCell(info);
            return cell;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return infos.Count;
        }

    }
}






