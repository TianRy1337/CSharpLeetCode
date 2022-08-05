namespace MyCalendarI
{
    public class MyCalendar {
        List<Tuple<int,int>> booklist = new();
        public MyCalendar() {
            
        }
        
        public bool Book(int start, int end) {
            foreach(var book  in booklist){
                if(Math.Max(book.Item1,start) < Math.Min(book.Item2,end)){
                    return false;
                }
            }
            booklist.Add(new Tuple<int, int>(start,end));
            return true;
        }
    }
}
