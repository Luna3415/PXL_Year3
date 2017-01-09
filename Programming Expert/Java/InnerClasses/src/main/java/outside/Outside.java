package outside;

import inner.OuterClass;
import inner.OuterClass.InnerClass;

public class Outside {

	public static void main(String[] args) {
		OuterClass outer = new OuterClass();
		OuterClass.InnerClass inner;
		//inner = outer.new InnerClass();			//When inner.OuterClass.InnerClass not imported is
		InnerClass inner2 = outer.new InnerClass();	//When inner.OuterClass.InnerClass is imported
	}
}
