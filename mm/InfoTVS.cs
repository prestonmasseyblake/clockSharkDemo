using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace mm
{
    class InfoTVS : UITableViewSource
    {
        List<Info> infos;
        public InfoTVS(List<Info> infos)
        {
            this.infos = infos;

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






