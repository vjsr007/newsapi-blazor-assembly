using Client.Shared.Components.Dropdown;
using System;
using System.Collections.Generic;

namespace Client.Stored
{
    public class NewsState
    {
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
    }
}
