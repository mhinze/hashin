using Machine.Specifications;
using NUnit.Framework;

namespace Hashin.specifications
{
    [Subject("")]
    public class describe_mash
    {
        static dynamic _mash;
        Establish context = () => { _mash = new Mash(); };

        It should_derive_from_hash = () => Assert.That(_mash, Is.AssignableTo<Hash>());

        It should_be_able_to_set_hash_values_through_assignment = () =>
        {
            _mash.test = "abc";
            Assert.That(_mash["test"], Is.EqualTo("abc"));
        };

        It should_be_able_to_retrieve_set_values_through_method_calls = () =>
        {
            _mash["test"] = "abc";
            Assert.That(_mash.test, Is.EqualTo("abc"));
        };

        // blocks specs nonsensical in c#

        It should_test_for_already_set_values_when_passed_a_has_method = () =>
        {
            Assert.False(_mash.has_test);
            _mash.test = "abc";
            Assert.True(_mash.has_test);
        };

        It should_return_false_on_a_has_method_if_a_value_has_been_set_to_nil_or_false = () =>
        {
            _mash.test = null;
            Assert.IsFalse(_mash.has_test);
            _mash.test = false;
            Assert.IsFalse(_mash.has_test);
        };

        It should_return_nil_instead_of_raising_an_error_for_attributeesque_method_calls = () =>
            Assert.Null(_mash.abc);

        It should_allow_for_multi_level_assignment = () =>
        {
            _mash.author.name = "Michael Bleigh";
            Assert.That(_mash.author, Is.EqualTo(new Mash(":name => 'Michael Bleigh'")));

            _mash.author.website.url = "http://www.mbleigh.com/";
            Assert.That(_mash.author.website, Is.EqualTo(new Mash("url => 'http://www.mbleigh.com/'")));
        };


        [Subject(typeof(Mash))]
        public class updating
        {
            
        }



    }
}