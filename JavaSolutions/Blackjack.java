
    public String largeHand(boolean isBlackjack, int dealerScore){
        if (isBlackjack) {
            if (dealerScore >= 10) {
                return "S";
            } else {
                return "W";
            }
        } else {
            return "P";
        }
    }
    public String smallHand(int handScore, int dealerScore) {
        if (handScore >= 17) {
            return "S";
        } else if (handScore <= 11) {
            return "H";
        } else {
            if (dealerScore >= 7) {
                return "H";
            } else {
                return "S";
            }
        }
    }