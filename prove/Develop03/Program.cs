using System;

/*
Stretch Challenge Information:
  - collected most of the input handling and displayed text into the Interface class
  - Used an Interface.AddReference method to allow multiple verse references stored in the same Interface instance, 
        with an Interface.PickOption method to allow the Interface to decide how to select a specific verse reference to display
  - Added a basic system to improve chances of words being hidden when other words haven't:
        If the random hiding chance succeeds on a blanked word, the next visible word will be hidden
        (meaning a word will only stay visible if its random chance fails along with all the blank words behind it,
        though this doesn't carry over between individual verses)
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Interface mainInterface = new();
        
        mainInterface.AddReference("John 3:16", [
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        ]);

        mainInterface.AddReference("Proverbs 3:5-6", [
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", 
        "In all thy ways acknowledge him, and he shall direct thy paths."
        ]);

        mainInterface.AddReference("Alma 36:1-30", [
        "My son, give ear to my words; for I swear unto you, that inasmuch as ye shall keep the commandments of God ye shall prosper in the land.",
        "I would that ye should do as I have done, in remembering the captivity of our fathers; for they were in bondage, and none could deliver them except it was the God of Abraham, and the God of Isaac, and the God of Jacob; and he surely did deliver them in their afflictions.",
        "And now, O my son Helaman, behold, thou art in thy youth, and therefore, I beseech of thee that thou wilt hear my words and learn of me; for I do know that whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day.",
        "And I would not that ye think that I know of myself—not of the temporal but of the spiritual, not of the carnal mind but of God.",
        "Now, behold, I say unto you, if I had not been born of God I should not have known these things; but God has, by the mouth of his holy angel, made these things known unto me, not of any worthiness of myself;",
        "For I went about with the sons of Mosiah, seeking to destroy the church of God; but behold, God sent his holy angel to stop us by the way.",
        "And behold, he spake unto us, as it were the voice of thunder, and the whole earth did tremble beneath our feet; and we all fell to the earth, for the fear of the Lord came upon us.",
        "But behold, the voice said unto me: Arise. And I arose and stood up, and beheld the angel.",
        "And he said unto me: If thou wilt of thyself be destroyed, seek no more to destroy the church of God.",
        "And it came to pass that I fell to the earth; and it was for the space of three days and three nights that I could not open my mouth, neither had I the use of my limbs.",
        "And the angel spake more things unto me, which were heard by my brethren, but I did not hear them; for when I heard the words—If thou wilt be destroyed of thyself, seek no more to destroy the church of God—I was struck with such great fear and amazement lest perhaps I should be destroyed, that I fell to the earth and I did hear no more.",
        "But I was racked with eternal torment, for my soul was harrowed up to the greatest degree and racked with all my sins.",
        "Yea, I did remember all my sins and iniquities, for which I was tormented with the pains of hell; yea, I saw that I had rebelled against my God, and that I had not kept his holy commandments.",
        "Yea, and I had murdered many of his children, or rather led them away unto destruction; yea, and in fine so great had been my iniquities, that the very thought of coming into the presence of my God did rack my soul with inexpressible horror.",
        "Oh, thought I, that I could be banished and become extinct both soul and body, that I might not be brought to stand in the presence of my God, to be judged of my deeds.",
        "And now, for three days and for three nights was I racked, even with the pains of a damned soul.",
        "And it came to pass that as I was thus racked with torment, while I was harrowed up by the memory of my many sins, behold, I remembered also to have heard my father prophesy unto the people concerning the coming of one Jesus Christ, a Son of God, to atone for the sins of the world.",
        "Now, as my mind caught hold upon this thought, I cried within my heart: O Jesus, thou Son of God, have mercy on me, who am in the gall of bitterness, and am encircled about by the everlasting chains of death.",
        "And now, behold, when I thought this, I could remember my pains no more; yea, I was harrowed up by the memory of my sins no more.",
        "And oh, what joy, and what marvelous light I did behold; yea, my soul was filled with joy as exceeding as was my pain!",
        "Yea, I say unto you, my son, that there could be nothing so exquisite and so bitter as were my pains. Yea, and again I say unto you, my son, that on the other hand, there can be nothing so exquisite and sweet as was my joy.",
        "Yea, methought I saw, even as our father Lehi saw, God sitting upon his throne, surrounded with numberless concourses of angels, in the attitude of singing and praising their God; yea, and my soul did long to be there.",
        "But behold, my limbs did receive their strength again, and I stood upon my feet, and did manifest unto the people that I had been born of God.",
        "Yea, and from that time even until now, I have labored without ceasing, that I might bring souls unto repentance; that I might bring them to taste of the exceeding joy of which I did taste; that they might also be born of God, and be filled with the Holy Ghost.",
        "Yea, and now behold, O my son, the Lord doth give me exceedingly great joy in the fruit of my labors;",
        "For because of the word which he has imparted unto me, behold, many have been born of God, and have tasted as I have tasted, and have seen eye to eye as I have seen; therefore they do know of these things of which I have spoken, as I do know; and the knowledge which I have is of God.",
        "And I have been supported under trials and troubles of every kind, yea, and in all manner of afflictions; yea, God has delivered me from prison, and from bonds, and from death; yea, and I do put my trust in him, and he will still deliver me.",
        "And I know that he will raise me up at the last day, to dwell with him in glory; yea, and I will praise him forever, for he has brought our fathers out of Egypt, and he has swallowed up the Egyptians in the Red Sea; and he led them by his power into the promised land; yea, and he has delivered them out of bondage and captivity from time to time.",
        "Yea, and he has also brought our fathers out of the land of Jerusalem; and he has also, by his everlasting power, delivered them out of bondage and captivity, from time to time even down to the present day; and I have always retained in remembrance their captivity; yea, and ye also ought to retain in remembrance, as I have done, their captivity.",
        "But behold, my son, this is not all; for ye ought to know as I do know, that inasmuch as ye shall keep the commandments of God ye shall prosper in the land; and ye ought to know also, that inasmuch as ye will not keep the commandments of God ye shall be cut off from his presence. Now this is according to his word."
        ]);

        mainInterface.AddReference("1st Nephi 2:15", [
        "And my father dwelt in a tent."
        ]);

        mainInterface.AddReference("John 11:35", [
        "Jesus wept."
        ]);

        mainInterface.AddReference("Mark 12:29-31", [
        "And Jesus answered him, The first of all the commandments is, Hear, O Israel; The Lord our God is one Lord:",
        "And thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind, and with all thy strength: this is the first commandment.",
        "And the second is like, namely this, Thou shalt love thy neighbour as thyself. There is none other commandment greater than these."
        ]);

        mainInterface.AddReference("Moroni 10:34", [
        "And now I bid unto all, farewell. I soon go to rest in the paradise of God, until my spirit and body shall again reunite, and I am brought forth triumphant through the air, to meet you before the pleasing bar of the great Jehovah, the Eternal Judge of both quick and dead. Amen."
        ]);


        mainInterface.PickOption();
        
        while (true) {
            mainInterface.DisplayReference();
            Console.WriteLine();
            Console.WriteLine();
            if (mainInterface.CollectInput().ToLower() == "quit" || mainInterface.AllHidden()) {
                break;
            }
            mainInterface.ObscureReference((float)0.25);
        }

        Console.WriteLine();
        Console.WriteLine();

        // Console.WriteLine("Hello Develop03 World!");
    }
}