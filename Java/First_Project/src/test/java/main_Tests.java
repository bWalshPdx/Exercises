import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static java.util.Collections.emptyList;

import static org.assertj.core.api.Assertions.*;
import static 

public class main_Tests {
    main _main = new main();
    @Test
    public void Bootstrap(){

        assertThat(returnString("True")).isEqualTo("True");

    }


    //Stopped at looking at hamcrest assertions:
    //https://www.youtube.com/watch?v=qkblc5WRn-U&t=1633s
    // @ 27:10

}
