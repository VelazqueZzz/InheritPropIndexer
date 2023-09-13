using System;
using System.Data;

class Alpha
{
    protected int alpha;
    private char[] symbs;
    public Alpha(int a, string txt)
    {
        alpha = a;
        symbs = txt.ToCharArray();
    }
    public virtual int number
    {
        get
        {
            return alpha;
        }
        set
        {
            alpha = value;
        }
    }
    public int length
    {
        get
        {
            return symbs.Length;
        }
    }
    public char this[int k]
    {
        get
        {
            return symbs[k];
        }
        set
        {
            symbs[k] = value;
        }
    }
    public virtual int this[char s]
    {
        get
        {
            return this[s - 'a'];
        }
        set
        {
            this[s-'a']=(char)value;
        }
    }
    public override string ToString()
    {
        
            string txt = "|";
            for(int k = 0;k < this.length; k++){
            txt += this[k] + "|";
            }
        return txt;
        }
    }
class Bravo: Alpha
{
    protected int bravo;
    public Bravo(int a,int b,string txt): base(a, txt)
    {
        bravo = b;
    }
    public override int this[char s]
    {
        get
        {
            if (s == 'a') return alpha;
            else return bravo;
        }
        set
        {
            if (s == 'a') alpha = value;
            else bravo = value;
        }
    }
}
class IngeritPropIndexerDemo
{
    static void Main(){
        int k;
        char s;
        Alpha A = new Alpha(100, "ABCD");
        Console.WriteLine("Object A:");
        Console.WriteLine(A);
        Console.WriteLine("A.number="+A.number);
        A.number = 150;
        Console.WriteLine("A.number=" + A.number);
        for(k=0,s = 'a'; k < A.length; k++,s++) {
            Console.WriteLine("Simvol \'{0}\' s kodom {1}", A[k], A[s]);
                }
        A[0] = 'E';
        Console.WriteLine(A);
        Bravo B = new Bravo(200, 300, "EFGHI");
        Console.WriteLine("Object B:");
        Console.WriteLine(B);
        B.number =400;
        Console.WriteLine("B.number=" + B.number);
        B['a'] = 10;
        B['d'] = 20;
        Console.WriteLine("B[\'a\']=" + B['a']);
        Console.WriteLine("B[\'b\']=" + B['b']);
        Console.WriteLine("B.number=" + B.number);
        for(k=0;k<B.length;k++) {
            Console.Write(B[k] + " ");
            B[k] = (char)('a' + k);
        }
        Console.WriteLine();
        Console.WriteLine(B);
    }
}

