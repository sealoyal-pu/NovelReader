﻿/** Author Note: =====
* Create By: rsdte      Date: 2021-07-15 22:18:05
*/

using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;
using Novel.Controls;
using Novel.Modules.Chartper;
using Novel.Modules.Chartper.Models;
using Novel.Modules.Chartper.ViewModels;
using Novel.Service;
using Novel.Service.Models;

namespace Novel.Modules.Document.ViewModels
{

    [Export(typeof(ActicleContentViewModel))]
    public class ActicleContentViewModel : Conductor<IChartper>, IDocument {
        private readonly NovelService _service;
        private readonly DefaultCharpterViewModel _defaultCharpterViewModel;
        private TreeListViewNode root;
        private readonly string _title = "章节";

        /// <summary>
        /// 当前小说信息
        /// </summary>
        private NovelInfo novel;

        public TreeListViewNode Root {
            get {
                return root;
            }
            set {
                root = value;
                NotifyOfPropertyChange();
            }
        }

        public NovelInfo Novel {
            get {
                return novel;
            }

            set {
                novel = value;
                Root = new TreeListViewNode(value.Title);
                _defaultCharpterViewModel.Novel = novel;
                NotifyOfPropertyChange(nameof(Novel));
                NotifyOfPropertyChange(nameof(Root));
            }
        }

        public string Name {
            get {
                return _title;
            }
        }

        public string TipText {
            get {
                return _title;
            }
        }

        public int Order {
            get {
                return 90;
            }
        }

        [ImportingConstructor]
        public ActicleContentViewModel(NovelService service, DefaultCharpterViewModel defaultCharpterViewModel) {
            this._service = service;
            _defaultCharpterViewModel = defaultCharpterViewModel;
            ActiveItem = _defaultCharpterViewModel;
            novel = new NovelInfo();
        }

        /// <summary>
        /// 窗口被激活事件
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override async Task OnActivateAsync(CancellationToken cancellationToken) {
            if(ActiveItem != _defaultCharpterViewModel) {
                ActiveItem = _defaultCharpterViewModel;
            }
            var ret = await this._service.GetCharpters(this.Novel.Href);
            ret.ForEach(x => Root.Children.Add(new CharpterNode(x.Title, root) { Href = x.Href }));
            Root.IsExpanded = true;
            await base.OnActivateAsync(cancellationToken);
            NotifyOfPropertyChange(nameof(Root));
        }
    }
}