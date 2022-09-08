using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NetCore.WordShuffle.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;   
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string ShuffleWord { get; set; }
        public string Name { get; set; }
        public string Word { get; set; }
        public void OnGet()
        {
            ShuffleWord = "enter the word you want to shuffle";
        }
        
        public void OnPostSubmit(ShuffleWordModel Property)
        {
            ShuffleWord = "successfully shuffled";
            SuffleMember(Property.Word, Property.Name);
        }

        public void SuffleMember(string word, string name)
        {
            char[] array = word.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            Word = new string(array);
            Name = name;
        }
        
    }
    public class ShuffleWordModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Word { get; set; }
    }
}