namespace Class
{
        class Counter
        {
            public delegate void MethodContainer();
            public event MethodContainer CountEvent;

            public void Count()
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 77)
                    {
                        CountEvent();
                    }
                }
            }
        }
    
}
