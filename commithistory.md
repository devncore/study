Exists files
```
local/ObservableObject.cs
local/RelayCommand.cs
```

mainviewmodel.cs

```
public class MainViewModel : ObservableObject
{
    private List<CommitHistory> _commitHistoryAllTime;
    
    private List<CommitHistory> _commitHistories;
    public List<CommitHistory> CommitHistories
    {
        get => _commitHistories;
        set { _commitHistories = value; OnPropertyChanged(); }
    }
    
    private ObservableCollection<IgnoreItem> _ignoreWords;
    public ObservableCollection<IgnoreItem> IgnoreWords
    {
        get => _ignoreWords;
        set { _ignoreWords; }
    }

    private string _filterKeywords;
    public string FilterKeywords
    {
        get => _filterKeywords;
        set { _ignoreWords; value; FilterKeywordChanged(value); OnPropertyChanged(); }
    }

    public MainViewModel()
    {
        _commitHistoryAllTime = CsvBuilder.Instance.LoadCsv();
        IgnoreWords = new ObservableCollection<IgnoreItem>();
        IgnoreWords.AddSwitchEvent(IgnoreWordChecked);
    }

    private void FilterKeywordChanged(string value)
    {
        foreach (var item in value.Split(';'))
        {
            if (IgnoreWords.FirstOrDefault(x => x.Text.ToLower() == item.ToLower()) is IgnoreItem ignoreWord)
            {
                continue;
            }
            else
            {
                IgnoreWords.Use(item);
            }
        }

        public void IgnoreWordChecked(IgnoreItem item)
        {
            CommitHistories = _commitHistoryAllTime
                .Where(x => !IgnoreWords.Where(x => x.Checked)
                .Select(w => w.Text.ToUpper()).Contains(x.CommitComment.ToUpper())).ToList();
        }
    }
}
```

data/CommitHistory.cs
```
public class CommitHistory
{
    public string CommitId { get; set; }
    public string CommitName { get; set; }
    public DateTime? CommitDate { get; set; }
    public string CommitComment { get; set; }
    
    private string? GetLastAttach(string line, int y)
    {
        int index = 0;
        string text = "";
        foreach (var t in line.Split(','))
        {
            if (index > 2)
            {
                text += t;
            }
            index++;
        }
        return text.TrimEnd('\'');
    }
}
```
