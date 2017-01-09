package be.pxl.main;

public interface A {

	default void foo() {
		System.out.println("foo van A");
	}
}
