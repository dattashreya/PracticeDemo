public class Area 
{
    public int len;
    public int br;
    public int ar;
    public Area(int l,int b) {
        this.len = l;
        this.br = b;
    }
    public void AreaCalculation(int l,int b) {
        this.len = l;
        this.br = b;
        this.ar = this.len * this.br;
    }
}