package be.pxl.kim.defaultMethods;

public interface CupCoffee {

	public void zetten();
	default public void bonenMalen() {
		System.out.println("Bonen malen");
	}
}
