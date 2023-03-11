using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _11_03_2023.Pages
{
    public class Page2Model : PageModel
    {
        public string Quote { get; set; }
        public string Author { get; set; }

        public void OnGet()
        {
            List<string[]> list = new List<string[]> { 
                new string[] { "��� �������� � ������� ����!", "���� ������"},
                 new string[] { "the wolf is not the one who is the wolf, but the one who is the wolf", "Jacque Fresco"},
                  new string[] { "���, �� ����� ������ � �������.", "����� ϳ�����"},
            };

            Random random = new Random();
            int index = random.Next(0, list.Count);
            Quote = list[index][0];
            Author = list[index][1];

        }
    }
}
