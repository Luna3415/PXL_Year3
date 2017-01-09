package anonymous;

public class OuterClass {
	public void method() {
		Number obj3 = new Number() {

			@Override
			public double doubleValue() {
				// TODO Auto-generated method stub
				return 0;
			}

			@Override
			public float floatValue() {
				// TODO Auto-generated method stub
				return 0;
			}

			@Override
			public int intValue() {
				// TODO Auto-generated method stub
				return 0;
			}

			@Override
			public long longValue() {
				// TODO Auto-generated method stub
				return 0;
			}
			
		};
		class SubClass extends Number {

			@Override
			public double doubleValue() {
				// TODO Auto-generated method stub
				return 0;
			}

			@Override
			public float floatValue() {
				// TODO Auto-generated method stub
				return 0;
			}

			@Override
			public int intValue() {
				// TODO Auto-generated method stub
				return 0;
			}

			@Override
			public long longValue() {
				// TODO Auto-generated method stub
				return 0;
			}	
		}
		
		Number obj = new SubClass();
	}
}
