public static class RandomNumber
{
    public static int Random(int min, int max)
    {
        Random ranNum = new Random();
        int num = ranNum.Next(min, max);
        return num;
    }
}