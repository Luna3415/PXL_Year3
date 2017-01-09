package supplier;

import java.util.function.Function;
import java.util.function.Supplier;

public class Text {
	private int i = 0;
	private String text = "Fuck off, you bastard!";
	
	public Supplier<String> split(String teken) {
		i=0;
		String[] data = text.split(teken);
		return () -> i < data.length ? data[i++] : null;
	}
	
	public Function<String, String> bewerk(String word) {
		return w -> word + w;
	}
	
	public static void main(String[] args) {
		Text text = new Text();
		Supplier<String> supplier = text.split(",");
		Function<String, String> function = text.bewerk(text.split(",").get());
		
		String woord = supplier.get();
		while (woord != null){
			System.out.print(woord);
			woord = supplier.get();
		}
		
		System.out.println();
		
		System.out.println(function.apply("test test test!"));
	}
	
}
