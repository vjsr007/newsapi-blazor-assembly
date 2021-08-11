using Client.Shared.Components.Dropdown;
using Client.Shared.Components.Post;
using System;
using System.Collections.Generic;

namespace Client.Stored
{
    public class NewsState
    {
        #region Topic
        public string TopicSelected { get; private set; }

        public event Action OnChangeTopic;

        public void SetTopic(string topic)
        {
            TopicSelected = topic;
            NotifyTopicChanged();
        }
        private void NotifyTopicChanged() => OnChangeTopic?.Invoke();

        #endregion

        #region Sources
        public ICollection<DropdownOption> SourceSelected { get; private set; }

        public event Action OnChangeSources;

        public void SetSources(ICollection<DropdownOption> sources)
        {
            SourceSelected = sources;
            NotifySourcesChanged();
        }
        private void NotifySourcesChanged() => OnChangeSources?.Invoke();

        #endregion

        #region Dates
        public ICollection<DropdownOption> DateSelected { get; private set; }

        public event Action OnChangeDate;

        public void SetDate(ICollection<DropdownOption> dates)
        {
            DateSelected = dates;
            NotifyDateChanged();
        }
        private void NotifyDateChanged() => OnChangeDate?.Invoke();

        #endregion

        #region Languages
        public ICollection<DropdownOption> LanguageSelected { get; private set; }

        public event Action OnChangeLanguage;

        public void SetLanguage(ICollection<DropdownOption> languages)
        {
            LanguageSelected = languages;
            NotifyLanguageChanged();
        }
        private void NotifyLanguageChanged() => OnChangeLanguage?.Invoke();

        #endregion

        #region SortBy
        public ICollection<DropdownOption> SortBySelected { get; private set; }

        public event Action OnChangeSortBy;

        public void SetSortBy(ICollection<DropdownOption> sortBy)
        {
            SortBySelected = sortBy;
            NotifySortByChanged();
        }
        private void NotifySortByChanged() => OnChangeSortBy?.Invoke();

        #endregion

        #region CurrentPage
        public int CurrentPage { get; private set; } = 1;

        public event Action OnChangePage;

        public void SetPage(int page)
        {
            CurrentPage = page;
            NotifyPageChanged();
        }
        private void NotifyPageChanged() => OnChangePage?.Invoke();

        #endregion

        #region NumberOfItems
        public int NumberOfItems { get; private set; }

        public event Action OnChangeNumberOfItems;

        public void SetNumberOfItems(int numberOfItems)
        {
            NumberOfItems = numberOfItems;
            NotifyNumberOfItemsChanged();
        }
        private void NotifyNumberOfItemsChanged() => OnChangeNumberOfItems?.Invoke();

        #endregion

        #region Articles
        public ICollection<Article> Articles { get; private set; }

        public event Action OnChangeArticles;

        public void SetArticles(ICollection<Article> articles)
        {
            Articles = articles;
            NotifyArticlesChanged();
        }
        private void NotifyArticlesChanged() => OnChangeArticles?.Invoke();

        #endregion
    }
}
