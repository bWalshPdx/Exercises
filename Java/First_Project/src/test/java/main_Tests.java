import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static java.util.Collections.emptyList;

import static org.assertj.core.api.Assertions.*;

public class main_Tests {

    @Test
    public void factors(){
        assertThat(factorsOf(1)).isEqualTo(emptyList());
        assertThat(factorsOf(2)).isEqualTo(Arrays.asList(2));
        assertThat(factorsOf(3)).isEqualTo(Arrays.asList(3));
        //assertThat(factorsOf(4)).isEqualTo(Arrays.asList(2, 2));
    }

    private List<Integer> factorsOf(int i) {
        var factors = new ArrayList<Integer>();
        if(i > 1){
            factors.add(i);
        }



        return factors;
    }



    //https://www.youtube.com/watch?v=qkblc5WRn-U&t=1633s
    // @ 27:10

}
