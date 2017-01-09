package shadowing;

public class OuterClass {

	private int field;
	
	public class InnerClass {
		private int field;
		
		public void setField(int value){
			this.field = value;
			OuterClass.this.field = value;
		}
	}
}
