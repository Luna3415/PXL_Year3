package be.pxl.main;

public class Clazz implements A {

	public void foo() {
		System.out.println("Foo van Clazz");
		A.super.foo();
	}
}
