package callBack;

public class Tekst {

	private String sentence;
	
	public Tekst(String s) {
		sentence = s;
	}
	
	public void printFilteredWords(WordFilter filter) {
		for (String word : sentence.split(" ")) {
			if (filter.isValid(word)) {
				System.out.println(word);
			}
		}
	}
	
	public void printFilteredWords2(WordFilter2 filter) {
		for (String word : sentence.split(" ")) {
			if (filter.isValid(word)) {
				System.out.println(word);
			}
		}
	}
	
	public static void main(String[] args) {
		Tekst tekst= new Tekst("Hello world!");
		tekst.printFilteredWords(new WordFilter() {
			
			@Override
			public boolean isValid(String word) {
				if (word.contains("world")) {
					return true;
				}
				return false;
			}
		});
		
		String a = "a";
		//a = "b"; -> error
		
		tekst.printFilteredWords(x -> x.contains(a));
		tekst.printFilteredWords(x -> WordFilter2.isValid(x));
		tekst.printFilteredWords(WordFilter2::isValid);
		tekst.printFilteredWords(new String()::contains);
		WordFilter2 filter = new WordFilter2();
		tekst.printFilteredWords2(filter);
	}
}
