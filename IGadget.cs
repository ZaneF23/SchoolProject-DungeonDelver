public interface IGadget
{

    bool GadgetUse(Dray tDray, System.Func<IGadget, bool> tDoneCallBack);
    bool GadgetCancel();
    string name { get; }

}
