public class Scripture
{

    private List<string > _scriptureList = new List<string>
    {
        "And to bring about his eternal purposes in the end of man, after he had created our first parents, and the beasts of the field and the fowls of the air, and in fine, all things which are created, it must needs be that there was an opposition; even the forbidden fruit in opposition to the tree of life; the one being sweet and the other bitter.",
        "26 But the Comforter, which is the Holy Ghost, whom the Father will send in my name, he shall teach you all things, and bring all things to your remembrance, whatsoever I have said unto you. \n27 Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.",
        "15 And Jesus answering said unto him, Suffer it to be so now: for thus it becometh us to fulfil all righteousness. Then he suffered him. \n16 And Jesus, when he was baptized, went up straightway out of the water: and, lo, the heavens were opened unto him, and he saw the Spirit of God descending like a dove, and lighting upon him: \n17 And lo a voice from heaven, saying, This is my beloved Son, in whom I am well pleased.",
        "And moreover, I would desire that ye should consider on the blessed and ahappy state of those that keep the commandments of God. For behold, they are bblessed in all things, both temporal and spiritual; and if they hold out cfaithful to the end they are received into dheaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.",
        "10 Behold, I am Jesus Christ, whom the prophets testified shall come into the world. \n11 And behold, I am the alight and the life of the world; and I have drunk out of that bitter bcup which the Father hath given me, and have glorified the Father in ctaking upon me the sins of the world, in the which I have suffered the dwill of the Father in all things from the beginning."
    };
    public string getScripture(int rnd)
    {
        string scripture = _scriptureList[rnd];
        return scripture;
    }
}