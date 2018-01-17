﻿namespace Tangle.Net.Tests.Cryptography
{
  using System;

  using Microsoft.VisualStudio.TestTools.UnitTesting;

  using Tangle.Net.Source.Cryptography;
  using Tangle.Net.Source.Entity;

  /// <summary>
  /// The key generator test.
  /// </summary>
  [TestClass]
  public class KeyGeneratorTest
  {
    #region Public Methods and Operators

    /// <summary>
    /// The test get key index is negative should throw exception.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestGetKeyIndexIsNegativeShouldThrowException()
    {
      var keyGenerator = new KeyGenerator(new Seed("TESTSEED9DONTUSEINPRODUCTION99999ZTRFNBTRBSDIHWKOWCFBOQYQTENWL9999999999999999999"));
      var privateKey = keyGenerator.GetKey(-1);
    }

    /// <summary>
    /// The test get keys with higher security level.
    /// </summary>
    [TestMethod]
    public void TestGetKeysWithHigherSecurityLevel()
    {
      var keyGenerator = new KeyGenerator(new Seed("TESTSEED9DONTUSEINPRODUCTION99999TPXGCGPRTMI9QQNCW9PKWTAAOPYHU9999999999999999999"));
      var privateKey = keyGenerator.GetKeys(1, 2, 2);

      Assert.AreEqual(
        "IQOTORFDCOZORDLUUQAXXNFCILODCMVOOEJEGUCZTSFMQONYDALBCAD9YETATQRRRFAHUAHU9VARQZPFWVLRUPXXPGDTQJDVJBMUMOBXFMEKFNGOIKUMZBIGNJGLWCPPCHHX"
        + "AJAI9RMRFJICRXVTIYLQWGTNRMOIE9VMHYAJLQPPEKPS9RZZJSPTDRRHRUOYOWMFGNOVMJDPDJHRGYYWPTIYCVNITYVMSHGC9NLAJWCZVEHJQIXDZBRPSZHC9JNTPTSJZAW9"
        + "9CIZLHIIDCONEDPUWBXVAQHRTICUQO9UQLFPLJUTIHYMIBRUZNCVSCZT9TNZQHCUEMTTOUWELUXJCMFRSZVOPBNZR9AGEAKUIXGOZQDGJKPOEYKDZJHDJ9RUSMUGPFIEQGAH"
        + "FHMDQLDI9HHWPBJFERFQAOIDPNGVQTARVJH9TJRKQJWRECXIUITPWNQSMDPJJEOPIGYJZTURMZDYFMZQJWJVEVWFZAHAGWSGLNUIEDFRRSXSA9ZGNYKXGCLKRSAUIUKYZTGC"
        + "B9RLGBPR9MIDZMLJHVGV9UIOZDQUEJEGXBSAOFZ9XGPHQNLNUEWOKHDSOWXDBIGQKAJMXQKJZTFHK9SHX9CVNINETMGCKJNI9PNSF9CZKZARPR9CR9LBWZOZXDATXDXYNFEJ"
        + "PPOE9VGUQFAFZKNJLAETHOUKAXCRFUKB9FG9IWCEPWIUHZPSAO9TRNPSQUDOZKSHERYZYYVVAWWDRUDAEJLHNCRFAMBSRZX9ISXVGXPWXC9CHNUKGHLYZHIV9HFXWOXBFZPL"
        + "XOMMSK9DSWPBJMKTLBMTVWNTWDUXSI9BHPBCSQJX9ZLFGZWIEQPFHYVEXSIEWIBEGIEDXP9ZBUQLJAON99KRVLHLBTLSIAENF9WLI9LBIXIUHLI9ESVBSGSKLXMFUOGJTJZD"
        + "QLMZTFDDJDBHJJLKBQULQSSNIYIQG9TAFZXPZOUJ9MUEZLQAT9SKI9VPRZ9LBWUYYPSZRLMLDITJOJEULG9BLDKKEKPXJKUIDORYDVNZFABCLINHNHZEZRYRTYCBNMMOZSNC"
        + "FYADBORKPLLDWW9LHUHHLFDRP9VTDLUO9ENPHJXAWJRQKVSUGFYDGWVGAPUFGYTQZFWSZTILZDHKHWGCKGZXPZFW9OMMGCQOXHPDIQDSZCVKBFZKEBUNYEBUIZSZWXMCSXPG"
        + "FYFDXFDZBQCNISTV9M9NLICOLTZQJELMBOOHYZ9WC9UJYMIGDSOVQXFFWBVMIXJWBMKQQBCXGREPAQIWPJXHIKWYYO9LVDOSOFJXB9FFDZRWJACEPVSUN9YNMJJQTYIIENLB"
        + "IGIRJKBWSWJFRHQRUCCDZY99BXGJIQOHMEPPNHPVQFFMYUZXWRCBOOGKAADLXZIEEUNYKQURKPAIBBYNFHJEOWX9SGRKSYINGKNORUGNKQMZUDBUJGWHALUYXII9XNKHVPYK"
        + "YMDHDZPWWWKYZESNZDXMDFHYJCXZMGQVTEIVOQTHVMDVUMQMMRSVWLFDGYEOJJX9DBCHSGMOWHZOLDNBSWCUJR9PGOIRRTSFDVZWTELIICRQFLPNFZMMQVLYNWKAMWDRTYLZ"
        + "9OEJGIVLQQTFNOWKUQFDCWVATINKDZROEENXEAMOOLKNOCLGANKKNZKUKZGWSI9JW9GUOARMFPHJPLSEXWXQATKBOTWMNVITSX9MWBYOGIIGMLJQXDYEWTJFPSUSDMMSXCOE"
        + "ULGOHEJYCSAOOTHDPTOYXTORYOLOVFMHYNPVHYQTGTIMSRDEEFB9VSBADXDNDQYRAASWQZGPCMPXH9YRRWOOKOFGIUOLNNEVCZOTXZPBQNPPLTCOXLMCXWSHNYYJEM9BTXNJ"
        + "YQM9DDLSTLZUBLAUOWDWKL9OSTWVJZPIDTOBQZKASTTUNWU9JECOZQXM9NXUOGKYKIOVSBDDPKIQUBBCCBVD9AXCAEMSND9DDYOESN9SBGIVTYGOTLVUCIDRFLXOZWIYBSWH"
        + "XPUSURKBXNBFYHCWNINLPYFIYPIPPVCNSVTQAQ9EGQLICGTHVCLGWHJVL9NBRNJTWNLCMXXQCBDVFLHONYRUBXYYAV9FSSLWBUIZCJMTJQCODHDZUAGZNFNCZPQRW9PRKDZR"
        + "V9IRFJAEDODDCNHZFBJPI9MBYAVNENYZOHOZCQBIVDSBKYQOBRZZYPGYSZCCGMAEXYZSGENLRSAHJLPRRZXCTAXMYUCDVEFB9J9FMTXZSVXMNBTWIGQZZFZZQJAKWMQGODXV"
        + "HJWNQVMPLTJ9OXYKPWPVVTCCCHSKSDZKACZXZHOUHHRSQHVBZXMOTPHXZLJSVXX9OGWYJNOEZAWKVSAVSEOSBJKCBNMG9EHFEBKDWLFLXNVWUCEYBQFKLOFLSQKMQIZCZZMI"
        + "KJBCNKMYMKTWABX9URWXDRINXJQA9UWFBKQZION9JSHWQBOLEEWVXDODFJEMBVGLMMZGIOSWOAEBNLL9KLINAZIW9FAYSRSJUGFSDHENJOSYOBTFPWTGFHNSDNDHGDMU9EAP"
        + "UVDQYXTECZPUYHIVAXCNOTUNKTZMZZRXQUFSMEKJNDLP9BKWLVWMGVTJTGLEPECPOBLHTGAFZMUBTSBEBTNXYJRMRVWBJLSZBCECAXZVAPMGSKGQUDOKEXN9JBWDVDRRIXNV"
        + "NJQSLNXKNHFKTUDFTNUQWIWQYZQGS9RABWASMDHUCGDOYTSDUNPLSMNAGKYEQZTGANCMJFVKBJMMHOVV9FTMRMTFMBEBNMBWXRRGBVEBZXSNTZRGIAQPBNGAMQEOEMCUYSLT"
        + "M9DKTSKCWDHTBDEQH9EVWYSDJXRVVEWARWXHKHZQCOIZWJ9JCYWOLUBPJQGCFECNXSQTVVLMQXRT9UEYVPYHXSZBWISVKFZXTFVQTNYSWBVKDADATCKDMUJLPPTWQXRFWKDM"
        + "OGQDIWRKEZLYZEACTGPQFDCIXRBBUKVHQVRDHVLICJZCWIORJWPMRIFLBZBLXKXIKFPDNLIBCTCYYNYDVRILCJZXHBDC9RKRNRHAJCUOLPTSTQIWTYARFGXMBLRSOXDFQQKV"
        + "RLWNEVHZGKIVKEBQSZBPRAWAYOOXIGEPOBZVQ9CJHYHIGV9VMHNNRVANNMKTKMLZLBWFGGSOFUIGLJUEQUSBYCWNIRUMICHACAWIOSRKXIEEFOIP9RF9RDSAYHWJOSUQGEIW"
        + "WTYRBJOPOPJZWZF9GZWUKMBMKUMSJI9UCPQFXNWCVLGL9UPZPLG9UDOWLRRZUMHOMEMRNTBBGU9UCDKJOUEITNRXIMHEII9EYUADPLRTFTUANAXYWVMBLGCEUAWHAHUWJXML"
        + "QWYJXQYNCXL9VVDTOKLMYV9OUWNDTCQFEDELEETNWNU9XXRBZGMYKOPBXZEZRKEJUZBAMUQDQKQRQDRWP9RXDTNQGPHDJDBVKBZ9GCOCRCKXCFSRIGRYEXGYOMKZOSQQGMUU"
        + "QGYBSUDUPFARYRP9JCQAHMIJUZCUTNTDGBVYKZHKIGXLIL99TVWNKFHBJHDPSPWIVGZYQYAOAWTPMUALUZQKCJBPBXPMNYJJIPCNXCDFYV9QQBJFVGIKIZWPIZCAOKNVSI9X"
        + "SUWZEHPORPLKNYOYTMHSIZAQ9ZLXJHWBHWIA9ACGLOB9UZJAFEYNS9GLOMNHJAHYJ9EBCHWVYKZDPC9G9XKBNSUBRLCVORIPAZZQFMDNUDPRVXTUKHXBKGKSYVZBNXRASYNC"
        + "URANZDYESQDIYSGCDI9HEIWARKXSRCAQO9MZYIMRKZBZHYWMHNWADLRFAPWSUOSRXDJYYMYTZXEOPVBJXHEW9VZQIXTPRIQWGEENDHTMOHKBEOWMFO9XSGY9AIOUBOYBIFBD"
        + "EQBRRCKJCJSWAKKZKBUQTAOKFSEHLJPHPTQGIAKDOCVJRUESHWSVXJVQVB9WIRMZUFPDTJVTVSEGMSGDNFOGGOVNUELOYGP9AAEKL9ZGKFCXFGFKXHX9SLQBCWVXTAAV9HUP"
        + "BLETXNLIYWKMAKXQTFYEADOYUGFGFLYKPDMEAXXXRQRBIJJUKBDLU9KAZPWCGWCW9KIHVSMMNHKDK9AMDDCLU9OYAXQONZWHDEWENLLGZGYXZJEIXHMAJKINTFXPVCMGPLYR"
        + "OGSQVIOXKJOCZGEPGLP9MIBVQXBBZQPU9L9QZOYQPPAGDJTCLDUELXZGQSQFKOQOFEHKJEMLCJ9ZNWARUEAFEDKQBQ9NKT9UHASO9JGXW9UBZGX9IEZFCYCWBINHW9DDWBUK"
        + "QZY9FIKKWVRAMGMSZDVUCSZKMPWHTGQUEPANTUWIYCKHENOG9OQKINYIPM99MAXPW9UB9BQWUXZKLJOSPEMGALNNLJDFYRZCSETCELPMEOGYBAXJ99NSTIHZOILSAUXUZSTV"
        + "BPNVFNHJMFIJNWJDPZ",
        privateKey[0].Value);
      Assert.AreEqual(2, privateKey[0].SecurityLevel);
    }

    /// <summary>
    /// The test get key with higher security level.
    /// </summary>
    [TestMethod]
    public void TestGetKeyWithHigherSecurityLevel()
    {
      var keyGenerator = new KeyGenerator(new Seed("TESTSEED9DONTUSEINPRODUCTION99999TPXGCGPRTMI9QQNCW9PKWTAAOPYHU9999999999999999999"));
      var privateKey = keyGenerator.GetKey(1, 2);

      Assert.AreEqual(
        "IQOTORFDCOZORDLUUQAXXNFCILODCMVOOEJEGUCZTSFMQONYDALBCAD9YETATQRRRFAHUAHU9VARQZPFWVLRUPXXPGDTQJDVJBMUMOBXFMEKFNGOIKUMZBIGNJGLWCPPCHHX"
        + "AJAI9RMRFJICRXVTIYLQWGTNRMOIE9VMHYAJLQPPEKPS9RZZJSPTDRRHRUOYOWMFGNOVMJDPDJHRGYYWPTIYCVNITYVMSHGC9NLAJWCZVEHJQIXDZBRPSZHC9JNTPTSJZAW9"
        + "9CIZLHIIDCONEDPUWBXVAQHRTICUQO9UQLFPLJUTIHYMIBRUZNCVSCZT9TNZQHCUEMTTOUWELUXJCMFRSZVOPBNZR9AGEAKUIXGOZQDGJKPOEYKDZJHDJ9RUSMUGPFIEQGAH"
        + "FHMDQLDI9HHWPBJFERFQAOIDPNGVQTARVJH9TJRKQJWRECXIUITPWNQSMDPJJEOPIGYJZTURMZDYFMZQJWJVEVWFZAHAGWSGLNUIEDFRRSXSA9ZGNYKXGCLKRSAUIUKYZTGC"
        + "B9RLGBPR9MIDZMLJHVGV9UIOZDQUEJEGXBSAOFZ9XGPHQNLNUEWOKHDSOWXDBIGQKAJMXQKJZTFHK9SHX9CVNINETMGCKJNI9PNSF9CZKZARPR9CR9LBWZOZXDATXDXYNFEJ"
        + "PPOE9VGUQFAFZKNJLAETHOUKAXCRFUKB9FG9IWCEPWIUHZPSAO9TRNPSQUDOZKSHERYZYYVVAWWDRUDAEJLHNCRFAMBSRZX9ISXVGXPWXC9CHNUKGHLYZHIV9HFXWOXBFZPL"
        + "XOMMSK9DSWPBJMKTLBMTVWNTWDUXSI9BHPBCSQJX9ZLFGZWIEQPFHYVEXSIEWIBEGIEDXP9ZBUQLJAON99KRVLHLBTLSIAENF9WLI9LBIXIUHLI9ESVBSGSKLXMFUOGJTJZD"
        + "QLMZTFDDJDBHJJLKBQULQSSNIYIQG9TAFZXPZOUJ9MUEZLQAT9SKI9VPRZ9LBWUYYPSZRLMLDITJOJEULG9BLDKKEKPXJKUIDORYDVNZFABCLINHNHZEZRYRTYCBNMMOZSNC"
        + "FYADBORKPLLDWW9LHUHHLFDRP9VTDLUO9ENPHJXAWJRQKVSUGFYDGWVGAPUFGYTQZFWSZTILZDHKHWGCKGZXPZFW9OMMGCQOXHPDIQDSZCVKBFZKEBUNYEBUIZSZWXMCSXPG"
        + "FYFDXFDZBQCNISTV9M9NLICOLTZQJELMBOOHYZ9WC9UJYMIGDSOVQXFFWBVMIXJWBMKQQBCXGREPAQIWPJXHIKWYYO9LVDOSOFJXB9FFDZRWJACEPVSUN9YNMJJQTYIIENLB"
        + "IGIRJKBWSWJFRHQRUCCDZY99BXGJIQOHMEPPNHPVQFFMYUZXWRCBOOGKAADLXZIEEUNYKQURKPAIBBYNFHJEOWX9SGRKSYINGKNORUGNKQMZUDBUJGWHALUYXII9XNKHVPYK"
        + "YMDHDZPWWWKYZESNZDXMDFHYJCXZMGQVTEIVOQTHVMDVUMQMMRSVWLFDGYEOJJX9DBCHSGMOWHZOLDNBSWCUJR9PGOIRRTSFDVZWTELIICRQFLPNFZMMQVLYNWKAMWDRTYLZ"
        + "9OEJGIVLQQTFNOWKUQFDCWVATINKDZROEENXEAMOOLKNOCLGANKKNZKUKZGWSI9JW9GUOARMFPHJPLSEXWXQATKBOTWMNVITSX9MWBYOGIIGMLJQXDYEWTJFPSUSDMMSXCOE"
        + "ULGOHEJYCSAOOTHDPTOYXTORYOLOVFMHYNPVHYQTGTIMSRDEEFB9VSBADXDNDQYRAASWQZGPCMPXH9YRRWOOKOFGIUOLNNEVCZOTXZPBQNPPLTCOXLMCXWSHNYYJEM9BTXNJ"
        + "YQM9DDLSTLZUBLAUOWDWKL9OSTWVJZPIDTOBQZKASTTUNWU9JECOZQXM9NXUOGKYKIOVSBDDPKIQUBBCCBVD9AXCAEMSND9DDYOESN9SBGIVTYGOTLVUCIDRFLXOZWIYBSWH"
        + "XPUSURKBXNBFYHCWNINLPYFIYPIPPVCNSVTQAQ9EGQLICGTHVCLGWHJVL9NBRNJTWNLCMXXQCBDVFLHONYRUBXYYAV9FSSLWBUIZCJMTJQCODHDZUAGZNFNCZPQRW9PRKDZR"
        + "V9IRFJAEDODDCNHZFBJPI9MBYAVNENYZOHOZCQBIVDSBKYQOBRZZYPGYSZCCGMAEXYZSGENLRSAHJLPRRZXCTAXMYUCDVEFB9J9FMTXZSVXMNBTWIGQZZFZZQJAKWMQGODXV"
        + "HJWNQVMPLTJ9OXYKPWPVVTCCCHSKSDZKACZXZHOUHHRSQHVBZXMOTPHXZLJSVXX9OGWYJNOEZAWKVSAVSEOSBJKCBNMG9EHFEBKDWLFLXNVWUCEYBQFKLOFLSQKMQIZCZZMI"
        + "KJBCNKMYMKTWABX9URWXDRINXJQA9UWFBKQZION9JSHWQBOLEEWVXDODFJEMBVGLMMZGIOSWOAEBNLL9KLINAZIW9FAYSRSJUGFSDHENJOSYOBTFPWTGFHNSDNDHGDMU9EAP"
        + "UVDQYXTECZPUYHIVAXCNOTUNKTZMZZRXQUFSMEKJNDLP9BKWLVWMGVTJTGLEPECPOBLHTGAFZMUBTSBEBTNXYJRMRVWBJLSZBCECAXZVAPMGSKGQUDOKEXN9JBWDVDRRIXNV"
        + "NJQSLNXKNHFKTUDFTNUQWIWQYZQGS9RABWASMDHUCGDOYTSDUNPLSMNAGKYEQZTGANCMJFVKBJMMHOVV9FTMRMTFMBEBNMBWXRRGBVEBZXSNTZRGIAQPBNGAMQEOEMCUYSLT"
        + "M9DKTSKCWDHTBDEQH9EVWYSDJXRVVEWARWXHKHZQCOIZWJ9JCYWOLUBPJQGCFECNXSQTVVLMQXRT9UEYVPYHXSZBWISVKFZXTFVQTNYSWBVKDADATCKDMUJLPPTWQXRFWKDM"
        + "OGQDIWRKEZLYZEACTGPQFDCIXRBBUKVHQVRDHVLICJZCWIORJWPMRIFLBZBLXKXIKFPDNLIBCTCYYNYDVRILCJZXHBDC9RKRNRHAJCUOLPTSTQIWTYARFGXMBLRSOXDFQQKV"
        + "RLWNEVHZGKIVKEBQSZBPRAWAYOOXIGEPOBZVQ9CJHYHIGV9VMHNNRVANNMKTKMLZLBWFGGSOFUIGLJUEQUSBYCWNIRUMICHACAWIOSRKXIEEFOIP9RF9RDSAYHWJOSUQGEIW"
        + "WTYRBJOPOPJZWZF9GZWUKMBMKUMSJI9UCPQFXNWCVLGL9UPZPLG9UDOWLRRZUMHOMEMRNTBBGU9UCDKJOUEITNRXIMHEII9EYUADPLRTFTUANAXYWVMBLGCEUAWHAHUWJXML"
        + "QWYJXQYNCXL9VVDTOKLMYV9OUWNDTCQFEDELEETNWNU9XXRBZGMYKOPBXZEZRKEJUZBAMUQDQKQRQDRWP9RXDTNQGPHDJDBVKBZ9GCOCRCKXCFSRIGRYEXGYOMKZOSQQGMUU"
        + "QGYBSUDUPFARYRP9JCQAHMIJUZCUTNTDGBVYKZHKIGXLIL99TVWNKFHBJHDPSPWIVGZYQYAOAWTPMUALUZQKCJBPBXPMNYJJIPCNXCDFYV9QQBJFVGIKIZWPIZCAOKNVSI9X"
        + "SUWZEHPORPLKNYOYTMHSIZAQ9ZLXJHWBHWIA9ACGLOB9UZJAFEYNS9GLOMNHJAHYJ9EBCHWVYKZDPC9G9XKBNSUBRLCVORIPAZZQFMDNUDPRVXTUKHXBKGKSYVZBNXRASYNC"
        + "URANZDYESQDIYSGCDI9HEIWARKXSRCAQO9MZYIMRKZBZHYWMHNWADLRFAPWSUOSRXDJYYMYTZXEOPVBJXHEW9VZQIXTPRIQWGEENDHTMOHKBEOWMFO9XSGY9AIOUBOYBIFBD"
        + "EQBRRCKJCJSWAKKZKBUQTAOKFSEHLJPHPTQGIAKDOCVJRUESHWSVXJVQVB9WIRMZUFPDTJVTVSEGMSGDNFOGGOVNUELOYGP9AAEKL9ZGKFCXFGFKXHX9SLQBCWVXTAAV9HUP"
        + "BLETXNLIYWKMAKXQTFYEADOYUGFGFLYKPDMEAXXXRQRBIJJUKBDLU9KAZPWCGWCW9KIHVSMMNHKDK9AMDDCLU9OYAXQONZWHDEWENLLGZGYXZJEIXHMAJKINTFXPVCMGPLYR"
        + "OGSQVIOXKJOCZGEPGLP9MIBVQXBBZQPU9L9QZOYQPPAGDJTCLDUELXZGQSQFKOQOFEHKJEMLCJ9ZNWARUEAFEDKQBQ9NKT9UHASO9JGXW9UBZGX9IEZFCYCWBINHW9DDWBUK"
        + "QZY9FIKKWVRAMGMSZDVUCSZKMPWHTGQUEPANTUWIYCKHENOG9OQKINYIPM99MAXPW9UB9BQWUXZKLJOSPEMGALNNLJDFYRZCSETCELPMEOGYBAXJ99NSTIHZOILSAUXUZSTV"
        + "BPNVFNHJMFIJNWJDPZ", 
        privateKey.Value);
    }

    /// <summary>
    /// The test get keys count is too low should throw exception.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestGetKeysCountIsTooLowShouldThrowException()
    {
      var keyGenerator = new KeyGenerator(new Seed("TESTSEED9DONTUSEINPRODUCTION99999ZTRFNBTRBSDIHWKOWCFBOQYQTENWL9999999999999999999"));
      var privateKey = keyGenerator.GetKeys(12, 0);
    }

    /// <summary>
    /// The test multiple key generation.
    /// </summary>
    [TestMethod]
    public void TestMultipleKeyGeneration()
    {
      var keyGenerator = new KeyGenerator(new Seed("TESTSEED9DONTUSEINPRODUCTION99999TPXGCGPRTMI9QQNCW9PKWTAAOPYHU9999999999999999999"));
      var privateKeys = keyGenerator.GetKeys(1, 2);

      Assert.AreEqual(
        "IQOTORFDCOZORDLUUQAXXNFCILODCMVOOEJEGUCZTSFMQONYDALBCAD9YETATQRRRFAHUAHU9VARQZPFWVLRUPXXPGDTQJDVJBMUMOBXFMEKFNGOIKUMZBIGNJGLWCPPCHHX"
        + "AJAI9RMRFJICRXVTIYLQWGTNRMOIE9VMHYAJLQPPEKPS9RZZJSPTDRRHRUOYOWMFGNOVMJDPDJHRGYYWPTIYCVNITYVMSHGC9NLAJWCZVEHJQIXDZBRPSZHC9JNTPTSJZAW9"
        + "9CIZLHIIDCONEDPUWBXVAQHRTICUQO9UQLFPLJUTIHYMIBRUZNCVSCZT9TNZQHCUEMTTOUWELUXJCMFRSZVOPBNZR9AGEAKUIXGOZQDGJKPOEYKDZJHDJ9RUSMUGPFIEQGAH"
        + "FHMDQLDI9HHWPBJFERFQAOIDPNGVQTARVJH9TJRKQJWRECXIUITPWNQSMDPJJEOPIGYJZTURMZDYFMZQJWJVEVWFZAHAGWSGLNUIEDFRRSXSA9ZGNYKXGCLKRSAUIUKYZTGC"
        + "B9RLGBPR9MIDZMLJHVGV9UIOZDQUEJEGXBSAOFZ9XGPHQNLNUEWOKHDSOWXDBIGQKAJMXQKJZTFHK9SHX9CVNINETMGCKJNI9PNSF9CZKZARPR9CR9LBWZOZXDATXDXYNFEJ"
        + "PPOE9VGUQFAFZKNJLAETHOUKAXCRFUKB9FG9IWCEPWIUHZPSAO9TRNPSQUDOZKSHERYZYYVVAWWDRUDAEJLHNCRFAMBSRZX9ISXVGXPWXC9CHNUKGHLYZHIV9HFXWOXBFZPL"
        + "XOMMSK9DSWPBJMKTLBMTVWNTWDUXSI9BHPBCSQJX9ZLFGZWIEQPFHYVEXSIEWIBEGIEDXP9ZBUQLJAON99KRVLHLBTLSIAENF9WLI9LBIXIUHLI9ESVBSGSKLXMFUOGJTJZD"
        + "QLMZTFDDJDBHJJLKBQULQSSNIYIQG9TAFZXPZOUJ9MUEZLQAT9SKI9VPRZ9LBWUYYPSZRLMLDITJOJEULG9BLDKKEKPXJKUIDORYDVNZFABCLINHNHZEZRYRTYCBNMMOZSNC"
        + "FYADBORKPLLDWW9LHUHHLFDRP9VTDLUO9ENPHJXAWJRQKVSUGFYDGWVGAPUFGYTQZFWSZTILZDHKHWGCKGZXPZFW9OMMGCQOXHPDIQDSZCVKBFZKEBUNYEBUIZSZWXMCSXPG"
        + "FYFDXFDZBQCNISTV9M9NLICOLTZQJELMBOOHYZ9WC9UJYMIGDSOVQXFFWBVMIXJWBMKQQBCXGREPAQIWPJXHIKWYYO9LVDOSOFJXB9FFDZRWJACEPVSUN9YNMJJQTYIIENLB"
        + "IGIRJKBWSWJFRHQRUCCDZY99BXGJIQOHMEPPNHPVQFFMYUZXWRCBOOGKAADLXZIEEUNYKQURKPAIBBYNFHJEOWX9SGRKSYINGKNORUGNKQMZUDBUJGWHALUYXII9XNKHVPYK"
        + "YMDHDZPWWWKYZESNZDXMDFHYJCXZMGQVTEIVOQTHVMDVUMQMMRSVWLFDGYEOJJX9DBCHSGMOWHZOLDNBSWCUJR9PGOIRRTSFDVZWTELIICRQFLPNFZMMQVLYNWKAMWDRTYLZ"
        + "9OEJGIVLQQTFNOWKUQFDCWVATINKDZROEENXEAMOOLKNOCLGANKKNZKUKZGWSI9JW9GUOARMFPHJPLSEXWXQATKBOTWMNVITSX9MWBYOGIIGMLJQXDYEWTJFPSUSDMMSXCOE"
        + "ULGOHEJYCSAOOTHDPTOYXTORYOLOVFMHYNPVHYQTGTIMSRDEEFB9VSBADXDNDQYRAASWQZGPCMPXH9YRRWOOKOFGIUOLNNEVCZOTXZPBQNPPLTCOXLMCXWSHNYYJEM9BTXNJ"
        + "YQM9DDLSTLZUBLAUOWDWKL9OSTWVJZPIDTOBQZKASTTUNWU9JECOZQXM9NXUOGKYKIOVSBDDPKIQUBBCCBVD9AXCAEMSND9DDYOESN9SBGIVTYGOTLVUCIDRFLXOZWIYBSWH"
        + "XPUSURKBXNBFYHCWNINLPYFIYPIPPVCNSVTQAQ9EGQLICGTHVCLGWHJVL9NBRNJTWNLCMXXQCBDVFLHONYRUBXYYAV9FSSLWBUIZCJMTJQCODHDZUAGZNFNCZPQRW9PRKDZR"
        + "V9IRFJAEDODDCNHZFBJPI9MBYAVNENYZOHOZCQBIVDSBKYQOBRZZYPGYSZCCGMAEXYZSGENLRSA", 
        privateKeys[0].Value);

      Assert.AreEqual(
        "RRVJULJGXMDUR9DEGFRBXWHHTSGMTZZYDQRWJKHV99XAWYSUEFLXUACXKSKALMYLWBAMWVRINPNDGXGODEFFGYJYJELKVCJYPFXOIAI9SUVCRLUGXCMDTEHHJUWGYLDSVQSY"
        + "XTEVSAXHPLZQHDDUPRAHRWGNCTDIFDQVLWVZLNWZYAEXWVIPKUDZSPLYCFMCDKDSLHCTZDNQYTRLGMFGR9EJISUOAWLEW9FWFBYCFBYGX9DBLUXOAIXEDTGLSXAH9NFEPVNN"
        + "NTUXSCSFYKXJDIMYVGU9BKLAIHYPYKE9KL9ALNGNEMUZEAQCICHTWDVLZSZDRWPXFWVGQTZISZCSSKQYZBLUSCLMALMBHAQUEHPIFTXZSM9IFEEHKRTJVCXRGCL9EOKEHDKN"
        + "GFNKQNBECQ9SBFCAZQHFPM9AUURHVLDGRCHQYHTSE9SV99ECSZPUFSDWPXGVQZYAYAWPJRKOOD9WGXLAQFGZLXUKEDSWRAPVFIBPPIPYHAKVJWTCD9YFDFZYHUNNEL9LILSG"
        + "WKPBRP9MXK9HUPSKECPWLGMFFCCUVWRXNFYSIZAZOEHBLMTE9EDOCSHHDGYEYEWYCCUJQMXLLUSRXUVJKVAHPO9CAQEMCSIYQMSUKBIOGUDDJJIOUMB9TGZDDDXSBK9KIFGF"
        + "9FYOXWHRWI99M9NYISSTMINBJDVCFEZMGNNW9EYWPYKWQWJTFVPQVP9BWJ9VTTZNZIMQBBDFAICJESMEGIJWEHHWBPLCPZRIDZJAZTEHRI9ELFMRASOAMMYUYWYNF9URSBWR"
        + "YCUKWYXTGXYMW9VCPAGPNEDQCZWMWOCLUKQPTIQKXPYMQBFWMGLKYHXPFAIGYDGKSIPZ9EHSHWBHO9M9KDQDFOVKXOXDNSXHJMXGGMGTQPVGRYPHCDHMYWSGXQJKAOZVNFEV"
        + "ZNDNRAAAUPQHECGNSUHMDNBTBHXVEIOCTJH9CYIPJSLPWFRAKONPLALPXDOEOQTIZFTPUAM9GLUEPURGKDJAEMTKUJFXFAYZVVVAFILXQLWXVFUHHLCVOKIJCCII9ONRWOZE"
        + "HAEGRHMTE9LPBNJPDJD9K9GNTYANA9SNHNWSAHHVCMNCWOQSJICTGCVEWOBHGTYZJXWOLCABCFJTSXQUMGRZSGNELULCLEUYKUKBAEEXZXPLISBBCHJRDKAOBPL9T9RRZTLS"
        + "FZWOXYBRWFDWSNDRNPU9KETYVYBLYPGJUPRFKJ9WKOVGYBQVSSMXQCDRSCWSYPZBLPNSG9JMVTEPWHTYOSQPTVRHVDAFVV9L9LEGWEGJKOZWDSPNL9CHGIIVMFGVOIFEZSXY"
        + "GCMWOBZLTHLBQ9KZQHQXSUGGDKGIRNFBMPRYWSQXFIMUGXEBSXVGRLX9XHLXEMBKETMIVQIQWAIFAFVJPYVDUNTHLDCULGSXAMJPQKATIFDUDXNGJZNDFMLBBDJBFNGGGMVS"
        + "YPDSQCGZUZDQHLUZEWWTTHYITIRVSNPQBAEEALYTOXZTZMSJAGZXUWNWJ9UTMIDYBDNDBX9RBTHURTCYOHWGGNAPMDDHYNGVLTKX99QKBJECELQSALNYOPFBLFLKXVTTACFB"
        + "NPFRDVHZRX9FPOUQMGFZZSKSTLGOTFUGLEX9GBAHXUPZUBSXBKQU9RLZHTIWHIVRMQLSKLSIYQIQSFEGLZQSLSCSUMDC9ERMHQCUEJCJD9SJDLNCHKEVCVERUMLPZQPLDDRE"
        + "XCRTCVJXPFFJZQPMKYXYQZFNU99SYX9DKSLLUTVNOMNXWFOGCHFZUVXAFDOUXEBZNDOOWUKMWNJAPIPLB9WUNJIPLMX9PTGLGDWLHSVRVUIJGNXEXKITXU9JDFSLWFZQUXRD"
        + "QXEILJVAJZIUSHYXZYJNEEAQEIZFSXKOKLQT9OUOZEEFFNEJUPCUTSYBLEXCEEOJATLTNKAYIYIQRUSWQNJELMNRR9GOXJZCLBOALYIIHZIWQLP9MQVJNRHHJIJQZRSAHRPH"
        + "ONWCGMZXGC9BGMBTYKSUXIMJIHXLGVQLWGCMGTOFADWBXNVUEJNAVBGIMVVZJTC9OSPPBYQBPPHGP9KMTKHSPAVRWDQLPRRWAYDZWEHMPWDSIFVJSBCLDZNGWSZZD99LPTJC"
        + "BUBSKAWUTBXBMXEJWCLFNTQ9MYVTLOTNRFZSVVMQWOPZDSCRVN9WNVIVIXLBBXS9SQJMZHGZVHX", 
        privateKeys[1].Value);
    }

    /// <summary>
    /// The test single key generation.
    /// </summary>
    [TestMethod]
    public void TestSingleKeyGeneration()
    {
      var keyGenerator = new KeyGenerator(new Seed("TESTSEED9DONTUSEINPRODUCTION99999ZTRFNBTRBSDIHWKOWCFBOQYQTENWL9999999999999999999"));
      var privateKey = keyGenerator.GetKey(0);

      Assert.AreEqual(
        "RYTWXBSSDDMFTHADVDRQN9HVOABBDMJDGAN9HPFAUOBZRKIWSVHJOPPETPFEF9UM9VZETGGPMRJFPQAUWAVSHPZLGWNXLE9EKMGENDWUGRFBV9IVBAQZBVKF9GKTIAUFTSRZ"
        + "NKGVITUYZDFRUXUJSVS9TRPMXJYKNBSHGUSUKVFLDHPSWNINOQLYTYYUY9W9EFDEHBCQZADZIIVSTOOQDVXKLCNHYZPUXTUUXTNAUDS9NZIVRHXNDMXNMOKHDEFGGLFMJIIT"
        + "MJ9MVDMFYJ9SY9IWSVRWITSWFMQJZIBETXXSXUDNSJQIJLMNXJGUUKBAII9YLSQVQOSHZQJWPEJQTS9IJAEKPFLQYLUANQGJTWEVNXOFYHFUJCTSFT9GXVCAPHUMTTTVPXHE"
        + "KORVSSMVWLALNGUSFRZYEUPJRDZ9ESSZYEHGYSYDKLLPLKUPUIGOKVBI9YJTN9MLQCHTLQYLLBXGKQM9DOIPOZEWOXJKHNASEUUCUVPCGL9HWCBQTTFIWUCMXVMEMVUKQWVU"
        + "ELWBMRQQGY9DO9UISPLULEKORKJVPLHUSDRNZJCNNUZEKMUDQJNRNNQWQOBHIYMEQDLRHLNNSLRLWJEXRVUKXBLOKAXPKWVAGFUFFKCKCJAYYFNMVHLIMQABMM9O9BCANIZX"
        + "YXYVSLWJOQEDKF9TGQGVGSRBZZCXTGAMROYCW9WCRDDBWSSHK9UOGASQBZVGLHLNKREHXXS9UWCOQGSOGRYQIVX9EZQAP9KTRTOTTDCFRYHL9HGIJNRBADEGVVZGEQLKJNFN"
        + "RDHIVSJARABAWPRB9DGQHROWIQZCFQJMNIDNDZRFFSABYCHRKGZNAXPNTCKAQAHXWSFHDZTSGZFOJQRSWDQOZELCYFHDVZADU9XCIPNKGAFQS9DFKYWJPQBRJK9MPXDTJOC9"
        + "URFTMQXDQLOFFLQCNMTZLROECGMXUCENMYHVIBJIO9DWOKRDPVVUUBZ9DYBKEYEFYOSXAYBGJTEJKSBZJRPLZSTWG9YVVF9OWXIC9MNSDMACOVRHNSTTGARCCSDJAWSRWDKT"
        + "OCDLZUAWQANXXX9RAFLIQUISYWPMDKTZWUZOKOWDHFJ9N9EMQVA9DRZGAIAJTIPBNIMTOL9JY9IIGYIXDIB9MZNTZYHJYMGAJEAOKZYYFAIVWQMQAJJJWECCJ9VZNMWNPMZA"
        + "VTDWEZBZSIGGDDPTIPKEASMWBHXNKTGKHNNBURXLCOBR9CYSXZXUYVOCLRJTXDQCZBHKZ9TRWRHYZAMEHLKCAKUYXAGUUANNYTJKUEIENVYXBQLTKWYPDFCCSGQKWRYZDASY"
        + "DKUMZYXEWUUROUXUHEFMWVRDNRVZJTANTDZIZUXQMBCIVAF9JCYQZEVAAQKRZY9OYLEURQGARRSDGSFEW9GIGFMJDPAY9NFXTQMXXTJUIMKKUE9BOOHUOHHENLI9DVYJJXLM"
        + "UKWKNWTBODTHZFBNQOVJIXOOMBULE9IGIITWQACCWZCOPDHNLHCKACNETJJNSOHQFO99RLRZFLPGMBYZYHKSNKYSULKENZODTDKFKJEZNWK9IDIPQLYGSETEMLYFDQXDHVA9"
        + "XJUUCWIDUMU9AE9HGOWDIVALKUVAZV9TBEGYPDWQKQOH9SNKLBTGEQZAJZXBJUIDA9YCBHONYIZTZWSAVXPGDDWN9PQWKXGGFUQSFUSPJIVLDDZUSZVRXMYZEBEXYFVLPZQQ"
        + "YAUZOYIUWGXNJEXCQT9GDFLFDCPZBSRHZSGYUHUBGQSSQEXB9PDPRQQ9YICHOWTJRWXGCZRTXC9ERXFFHLDMMVKF9LULV9LDQPXJAHUKWZNINFHTCSYNAXFST9IFRAXPASIJ"
        + "9WJWWFO9SYIQZNDMVXG9JXONUDMVGSNRQIJKVEDCGHWKEDOGED9YPQIXBUCZJRSMRMS9RJTFIYDIXAQMWNXGHHTCJLCSQNH9CNP9PJZCLIBQQBNMEY9PIJJLXPLREAHPKOZD"
        + "JMPVYNUK9EMRVEJVMCQPPW9HOUHQ9YNNBXGLDLUJQEQFXTDTKHDREEIHHKIWWSPKWYQYXLGXUEFAIWSA9NSDXWPSKISBADFJHJCSCNRORALCQNMIJ9U9TNCHZOC9NARJWQPH"
        + "O9HALCYZMNPCIV9VROERYT9UCNLZGKJEORFT9AMEZCXOVUIXSEPEIBMUNPPDEWIAAKGRYJANZDY", 
        privateKey.Value);

      privateKey = keyGenerator.GetKey(1);

      Assert.AreEqual(
        "PUQKFGMMWIEFMSGJI9QGVRYOCAPKTRJAOJLGGLURVTWDOWOI9ZHKHSVC9GPKNPHDTDMSMJNGNXDR9NDYDRMUM9CTOI9MCGMCRAARLPVUSJGXEYRRBUSUQLGMTDGGGWYASWTK"
        + "KJHHBZ9BIYVNKGHKCTXVVJLFSWXW9WVU9NWTKO99ZZP9FOMLULMJPZZEAJBZXMW9BDIWBMZMAERMLVPW9ADZKWQLSSHCYZZQIGXDBRDEEHUBZV9FJBIOPPAAE9RMKMAQFHYW"
        + "ELQPUAFTMBBXFSPOIVJL9QDYZLDTPMLZQSEJHWEBAUTWAIFAUSGHZMYPSVBDTKQKWQUQNRIEMYMNS9AYZJGURKDWEZHVGBJIOJKHBVWXJVFUVBZKOMWIHNPKV9SWRHYNKN9T"
        + "WNDYETPNXYKRMRPLDXUMGQ9GNSF9KHFXVQVIDCQRJJL9DFZHOFFNMJDO9EEAYTLHUTWHJWKKONESMCENCALGTLDZNBUWLBKMKEPXTTHLBQLTVDBXZNLFJRZM9MSGLUDYPBUD"
        + "ISGNOAXXZNPEQQXFDZAKEPHJZHGDTXDBHPTQLPCLBXDZERTCNJQYLSKSVOAXUBQNWKGOIMHJIOBYPYUBANJTXBOGLSASYWMKV9JZTVNZVOZJCEOUVWXTWQPWNVIWUAB9IPGJ"
        + "KREMJCAEMOZJJXQGZTAUBITQBMCARFG9NWLTWOYCWSBKTKXXJRRIFFDSKF9AMJBZIMFQXVRSSB9NXXLXORUHEKOWAQHZVFUETBTRCDQFFNGLTFKSQNOJWEXTOBWDGBMDSNLQ"
        + "BORKWPMUNGIKQQNPBCFRDZKCEJUKFWAKJXKVVTJMP9NGUAYVCIHKKYOEQBONDIOIOQAYYYGJDI9EIOIHFCBJTEUOHGASNXKVFR9QGWWQNQEWLNYLRBDLPBGSSEFGHIKLIYHR"
        + "KR9YHZTMWSOSMPIJKNKYG9TRXMKIYZLTCQOEXYWDUTRXLMRWYZJVH9LPTIDYINNPZFTPCL9HRXJYQXEAXRXPN9RINJHBYJPHEFQJPDVHKJJKIAQWVNKRBD9WLVIDGKDXXGJF"
        + "EIZJTYIC9HGYCZH9MQROVDVDVWFULPNSHZCUOUVABLAYGFSOVTABUUWUY9ACVPAJQCOJCXJOML9VJDSIHNVRR9RBNGCUAIVBWNGFDJWVWHJQFXMXYDWKOMFVPNBWJKIBXY9Z"
        + "LYSHEMWPCDXIVOUKKTHYBHBNI9YYLNGYYDOLUAKUKFRJZA9FYCFNTFTNBCXLMMCZIJOPJFIWYENQOHXWIAT9JODYDOEHESLGHZIMFGRKAVHZSZYLKTYSCHKQFSDTSHTOWHHQ"
        + "XGFKAYYCMPYTTJFQPLEYFMLAQBPYMFPYYLR9JQPUBMJUVDYSGUXVVLSRXJJEERZVSYKDPCTOXQNMFWAXQXIGUQRDKUQD9XDTZHRZJGNQCNORSDHWSCZGFLZ9PCCUPSVQCYUT"
        + "9HGXHZHPNMSBFQIDEHLMWGVJAWUXSSV9VRRIBRBOTSWUAVMWSTBVXNCAPMCQRSTMBFZOCAYLBVSAXBTDIUYQMDDGT99YMUVTIHLGFUYJCYFJLLX9GBAGAVISAZ9QJSKNHXVX"
        + "YIVKOARIA9YFDGSMPPWPJFCHAYGDRJJ9GYKYAMFS99OMOTEBOGODKUITJWFOMRQNBS9ZMCFIFJKISKKAJFPGVWWOERDSFCUEBSZPTKYMTTRAFLWYOZYJDNYIQWTBSLANDXQX"
        + "QZUYCMKQINKOAXGHVMEGWLWTJPKJUPWCXRPZVDMBRDSQLTKLNIDXINWCRYYNSLDT99ORWVIFHY9DFXFXQM9LPRMFOVZJSMJAQAMRPAWNTGEA9VWBQTXJCGYZHPKWLL9VCVDQ"
        + "PUIKFLGK9WKMMUWQPCJCWDK99QLUYUPJIVPMNL9QZK9QDTGFFKMMAOSEPWKOGLIVYDVKRAAGDFMEULWVCUPUV9ZOTSKORD9CTI9DFYBOJMEDOSOHNARELZNFPGXFLEPBLYQO"
        + "WMRNZLVDRNBWOTRDMHEURDWGQKCXZEX9UAWBSEKOVDG9CGXOZXMPYCUWQTKLKAYGQNTPNUXAFOJTZRRPSAQ9HGOPFFVMYTEEFKOWZWVMIAYZULGWODOCOYHIJITYBDLQCTXZ"
        + "TJUIGGWPUHOWVQSDDNVWNUNGUPUPYBZMSZTYXLRYSGVLVMGERUNIPZDDFHLJCDIHVINETYGWNAY", 
        privateKey.Value);

      privateKey = keyGenerator.GetKey(13);

      Assert.AreEqual(
        "TIUQQXOOYTKCESSBBGKKVJQPSJNVTAGCTAJVRJNXJUIHXWXQHSTACBRP9BJCSQD9CAFNQNNFVEPMYFCPYKXRCNWZHYKYCRSFTAZTPGQXBIMGAZEXABLUJQKEQMKAOUXYNICZ"
        + "YWDIBLZVJYGUPET9BAV9PTM9TJLHTWLXV9NXMNDNDYHTLIVGZJSEHIBWOYIXABKP9OAPPGWTUNLKYDFNWSFDTGRDPTMABYOPCTZM9LQIESPNNVZVYGGCJOHC9NSXMX9ETPGH"
        + "NQACONLQJIHRNAKUYMLSGTEJUO9MZGEQZPQBTQXKWJDJLFSRBPERWKVHUZXANWMOKWQPPGVFZRVUEOWDMZM9IOZUCOYTQIRZXWDYWAHGOATEW9AMZNSTZRZCQYS9MYREAFMT"
        + "BIQFUUZKBSWFSNZO9HDBVMNTXX9EAAVTIZSARDP9ZKCUBIRPPGWWXV9PDXLCSDKLWANVLTXPTEBUAHJJL9LESHCQQWZIYMRNCVYMDQUQFWNAGTCOQBNCLHZMJRNYWIZXDLFF"
        + "JVA9OTEVHOQZKUDHXLHLZLH9YZR9WBCMFOVRUCDBNVHRGMAYLIEKNDCSWMT9HXU9SDLMLKOBEISWYQCSXYINQNNHSOGTZTZNUXNVHBBOUCFIKIICILJADHTDBJNTPORFBQGC"
        + "LJKOMVRRBBXZJLRVKBLELUDBQGFHOHRAXTHVUSJMZBO9KKXZZNNKJEN9GNYVBDFZDUQNYTENTFYUSOGJOOJJFGAADFKNKMVWKUWCCTACYZZEYTIKBJP9SCUGTRYLYCBXCIQP"
        + "LQFKARVWU9VKUGUZYXZXCNSXGNZBXIZDDCSMTOHOCCI9GGXMNAYLVMITJXEN9MKUAPNUBBSZCXNWN9DKMHROJQPNWEGHDPKPVNZLFMHXDUOTBVBGDLWGSODW9ACJJIJW9NXD"
        + "YOGFIPHPET9AJZXNKYWXKGRSINIODDS9IAT9LAEQWUODEBW9MQIDKZPIINGKUXZGKGNXTPDMUOKEKKM9TQQJCGMOGXITJAVODWPFCJX9UEDVABYLUIUUUCAXUFWZCYWGWL9Z"
        + "FZP9YSD9RJCMZJQZEQJLAZNJPSPOPJCEPOJTFZOBTWWLHFAALRHISBVFUYAHNBMT9ITDDFKREXTZUXHCOL9VDDVQAXKBKZSLVEREOOSPPZHIWH9AQHVNZEXVCWPQLVUGPVBZ"
        + "GIRYUMQXPJBGP9AUFCHZHTENRJAKJHLKORDSYZYISTFUPAZNIWUJUGEDFSI9XMZRLBHCZSGOVXINMDJZYSPHBOVTTDCYONQKZ9UJHNJDWR9YT9MJNSFFUQDCLPOXFV9RDQSA"
        + "TGCCWAAZVVJSCZLZTPJXBFBUDLIBABLKLZFZUHGARDDFX9OZDXBZNSFEWYXNSLCMHFROWWJHK9IRLEZZEVFWJ9KCEWGVHXTSXWMJSWPH99BU9GVXOIHTFTOGFMGZVCYCPDHZ"
        + "OUUB9DEPJLJCFFKEGMBYLLSXEDGWNPMWCSQOAMDITYDHDPTDQRKMKPAJIRLMSAN9OWDOYZQHJJSVVOSYIYCMYVXEAOOFNNRWKJWNYDEZOLZ9MMMSUIPWIYKWZVEFKSTARVVO"
        + "UONUBAXJEFKJRNLDBQTRYAWK9NZYFRBCYVPZOACJPZRSAFYQPA9KJGZMAKKPAAUYC9NQGEPWKUVCHPSUNQDDMOIMKCLLBSACBXDVXUDWYOUCVOVZCNNRAURQFUPQGNB9CAXS"
        + "CPXPFPJENYWFBOJFFWZAUUTYRRQQMRBWUQOMJYPMONU9EYWJSGQQZHHZSHF9XQPIADAUHDKOIWJJGRLIPZQJ9LKPJRBHRTKUBWQHAOKZKT9GPDTSRXDRESZXMCMRNGUJOJPC"
        + "CSFMMPITLHU9FEBFMYLCBPCFEFXAZXYZRZFZ9KIQINS9GSN9BZLMMODAPNORGPMYNTXXASTKLVIGMUGJWRSLMLIDQYHXNTBDZR9EQDBDUZVSIALOEHBBUS9QILWCBIYYUSHZ"
        + "RNICAYREZANRQWGGBJZCMSB9TRXXCUSPIIEJLKLEOMVCYHRNI9KEHPXAIUQIFUNSVKJMEUMLBXSIHQUFK9QLA9UTBJZQGAQHWXVHWXYSEPCDO9M99HYRPAXFXHQENZHNBWXD"
        + "VN9KOMUINNCIMWKWI9QITAORLVJL9HRYSDNIQNAAQOQPSQNCQCGYAPIYSNOPHECZJYVTVVMKOUZ", 
        privateKey.Value);
    }

    #endregion
  }
}