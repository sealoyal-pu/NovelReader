﻿using Caliburn.Micro;
using Novel.Service.Models;
using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;

namespace Novel.Modules.Document.ViewModels {

    [Export(typeof(IDocument))]
    public class BeautifulViewModel : Screen, IDocument {
        private readonly string _name;
        private readonly string _icon;
        private readonly bool _show;
        private BindableCollection<NovelInfo> novels;
        private NovelListViewModel novelList;
        private HelloViewModel helloViewModel;

        public string Name {
            get {
                return _name;
            }
        }

        public string Icon {
            get {
                return _icon;
            }
        }

        public bool Show {
            get {
                return _show;
            }
        }


        public BindableCollection<NovelInfo> Novels {
            get {
                return novels;
            }

            set {
                novels = value;
                NotifyOfPropertyChange(nameof(Novels));
            }
        }

        public NovelListViewModel NovelList {
            get {
                return novelList;
            }

            set {
                novelList = value;
                NotifyOfPropertyChange(nameof(NovelListViewModel));
            }
        }

        public HelloViewModel HelloViewModel {
            get {
                return helloViewModel;
            }

            set {
                helloViewModel = value;
            }
        }

        public BeautifulViewModel() {
            this._name = "唯美纯爱";
            this._icon = "";
            _show = true;
            novels = new BindableCollection<NovelInfo>() {
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
                new NovelInfo {
                    Href = "/book/164873/",
                    ImageSource = "https://www.23qb.net/files/article/image/164/164873/164873s.jpg",
                    Type = "言情女生",
                    UpDateTime = "2021-05-30",
                    Title = "都市无敌战神",
                    Summary = "五年前，被陷害入狱！五年后，他荣耀归来，天下权势，尽握手中！我所失去的，终会千百倍的拿回来！…",
                    Status = "连载中",
                    WordCount = "4074653",
                    LastCharpter = new NovelCharpter {
                        Title = "第1736章 震惊遗落大陆",
                        Href = "/book/164873/84252144.html",
                    }
                },
            };
            novelList = new NovelListViewModel(novels);
            helloViewModel = new HelloViewModel();
        }

        protected override Task OnActivateAsync(CancellationToken cancellationToken) {
            return base.OnActivateAsync(cancellationToken);
        }
    }
}
