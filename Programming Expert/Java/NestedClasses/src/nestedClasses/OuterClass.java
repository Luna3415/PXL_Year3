package nestedClasses;

public class OuterClass {
	private int field;
	
	public static class NestedClass {
		private int a;
		public void setField(OuterClass outer, int field) {
			outer.field = field;
		}
	}
	
	public static class NestedClass2 {
		private int b;
		
		public static void setField(OuterClass outer, int value ) {
			outer.field = value;
			NestedClass classA = new NestedClass();
			classA.a = 5;
		}
	}
	
	public static void main (String[] args) {
		OuterClass outer = new OuterClass();
		
		OuterClass.NestedClass nested = new OuterClass.NestedClass();
		nested.setField(outer, 4);
		
		OuterClass.NestedClass2 nested2 = new NestedClass2();
		nested2.setField(outer, 5);		//This works, but is bad
		NestedClass2.setField(outer, 3);
	}

}
