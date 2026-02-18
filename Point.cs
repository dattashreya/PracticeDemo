namespace Methods {
    public class Point {
        public int x;
        public int y;
        
        public Point(int a,int b) {
            this.x = a;
            this.y = b;
        }
        public void Move(int a,int b) {
            this.x = a;
            this.y = b;
        }
        public void Move(Point newlocation) {
            this.x = newlocation.x;
            this.y = newlocation.y;
        }
    }
}