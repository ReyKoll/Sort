using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void GetArray_SortedArray_Returned()
        {
            string actualString = "——«— «««  —«—— «";
            char[] actualArray = actualString.ToCharArray();
            string expectedString = "««««««    ——————";
            char[] expectedArray = expectedString.ToCharArray();

            Sort.Presenter.SortPresenter sortPresenter = new Sort.Presenter.SortPresenter();
            actualArray = sortPresenter.GetArray();

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void SetArray_InputArray_IsNotNull()
        {
            char[] actualArray = null;

            Sort.Presenter.SortPresenter sortPresenter = new Sort.Presenter.SortPresenter();
            actualArray = sortPresenter.SetArray();

            Assert.IsNotNull(actualArray);
        }

        [TestMethod]
        public void SetArrayAndGetArray_InputArrayAndSortedArray_AreNotEqual()
        {
            char[] inputArray = null;
            char[] sortedArray = null;

            Sort.Presenter.SortPresenter sortPresenter = new Sort.Presenter.SortPresenter();
            inputArray = sortPresenter.SetArray();
            sortedArray = sortPresenter.GetArray();

            CollectionAssert.AreNotEqual(inputArray, sortedArray);
        }
    }
}
