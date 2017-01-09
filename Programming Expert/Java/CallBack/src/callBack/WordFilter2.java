package callBack;

public class WordFilter2 {

	public static boolean isValid(String word) {
		if (word.contains("Hello")) {
			return true;
		}
		return false;
	}
}
