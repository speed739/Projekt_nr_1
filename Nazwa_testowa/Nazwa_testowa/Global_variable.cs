namespace Alledrogo
{
    static class Global_variable
    {
        public static string IDklienta { get; set; }
        public static bool User_status { get; set; } = false;// zmienna określająca czy użytkownik jest zalogowany
        public static int Change_counter { get; set; } = 0; // zmienna pomocnicza do zmiany licznika koszyka 
        public static double Bill { get; set; } = 0; // zmienna naliczająca na rachunek
    }
}