import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static java.util.Collections.emptyList;

import static org.assertj.core.api.Assertions.*;

public class Main_Tests {

    @Test
    public void Bootstrap(){
        var main = new Main();
        assertThat(main.returnString("True")).isEqualTo("True");
    }
}
