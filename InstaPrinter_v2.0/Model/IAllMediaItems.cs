using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaPrinter_v2.Model
{
    interface IAllMediaItems
    {
        public List<IMediaItem> mediaItems;

        public void reloadMediaItems;
        public void loadMoreMediaItems;

        public bool reloadMediaItemsInProgress;
        public bool loadingMoreMediaItemsInProgress;
    }
}
