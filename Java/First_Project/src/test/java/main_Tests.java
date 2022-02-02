import org.junit.Assert;
import org.junit.Test;

import java.util.List;

import static java.util.Collections.emptyList;
import static org.assertj.core.api.Assertions.*;

public class main_Tests {

    @Test
    public void factors(){
        assertThat(factorsOf(1)).isEqualTo(emptyList());
    }

    private List<Integer> factorsOf(int i) {
        return emptyList();
    }


    //Stopped at looking at hamcrest assertions:
    //https://www.youtube.com/watch?v=qkblc5WRn-U&t=1633s
    // @ 27:10

}
