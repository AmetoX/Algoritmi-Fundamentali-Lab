namespace Structura_de_date_23_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateL st = new DateL();
            int n = 1;
            switch (n)
            {
                case 0:
                    st.Push(4);
                    st.Push(5);
                    st.Push(2);
                    st.Push(7);
                    st.Push(1);
                    st.view();
                    break;
                case 1:
                    st.Push2(4);
                    st.Push2(5);
                    st.Push2(2);
                    st.Push2(7);
                    st.Push2(1);
                    st.view();
                    break;
            }
        }
    }
}