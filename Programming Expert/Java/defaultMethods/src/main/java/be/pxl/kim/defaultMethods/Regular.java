package be.pxl.kim.defaultMethods;

public class Regular implements CupCoffee, OerEcht {

	public void zetten() {
		System.out.println("Een gewone kofie zetten");
	}

	@Override
	public void bonenMalen() {
		// TODO Auto-generated method stub
		CupCoffee.super.bonenMalen();
	}
}
