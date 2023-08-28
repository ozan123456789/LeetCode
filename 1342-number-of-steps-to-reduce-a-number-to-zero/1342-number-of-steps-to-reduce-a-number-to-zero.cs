public class Solution {
    public int NumberOfSteps(int num) {
        int i=0;
        while(true){
        if(num==0)
        {
            break;    
        }
        if(num%2==0)
        {
        num=num/2;
            i++;
        }
        else if(num%2==1)
        {
            num=num-1;
            i++;
        }
    }
       return i;
        
    }
}