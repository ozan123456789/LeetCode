public class Solution {
    public int NumberOfSteps(int num) {
        int count=0;
        while(num>0){
       
        if(num%2==0)
        {
        num=num/2;
        
        }
        else if(num%2==1)
        {
            num=num-1;
        
        }
            count++;
    }
       return count;
        
    }
}