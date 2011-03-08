using Machine.Specifications;
using NUnit.Framework;

namespace Hashin.specifications
{
    [Subject("")]
    internal class describe_hash
    {
        It should_be_convertable_to_a_hashin_mash = () =>
        {
            var mash = new Hash(":some => 'hash'").to_mash();

            Assert.That(mash, Is.InstanceOf(typeof (Mash)));

            Assert.That(mash.name, Is.EqualTo("hash"));
        };

        It stringify_keys_should_turn_all_keys_into_strings = () =>
        {
            var hash = new Hash(":a => 'hey', 123 => 'bob'");

            hash.stringify_keys();

            hash.ShouldEqual(new Hash("'a' => 'hey', '123' => 'bob'"));
        };

        It stringify_keys_should_return_a_hash_with_stringified_keys = () =>
        {
            var hash = new Hash(":a => 'hey', 123 => 'bob'");

            var stringified_hash = hash.stringify_keys();

            hash.ShouldEqual(new Hash(":a => 'hey', 123 => 'bob'"));

            stringified_hash.ShouldEqual(new Hash("'a' => 'hey', '123' => 'bob'"));
        };
    }
}