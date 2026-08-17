import { findNewApartment } from '../findNewApartment.js'
import { describe } from 'mocha'
import { expect, assert } from 'chai'

describe('test_findNewApartment', () => {
    describe('isGoodLocation', () => {
        it('should throw error on invalid input', () => {
            assert.throws(() => findNewApartment.isGoodLocation(['Sofia'], false), 'Invalid input!');
            assert.throws(() => findNewApartment.isGoodLocation('Sofia', 1), 'Invalid input!');
            assert.throws(() => findNewApartment.isGoodLocation('Sofia', null), 'Invalid input!');
            assert.throws(() => findNewApartment.isGoodLocation('Sofia', undefined), 'Invalid input!');
        });
        it('should return "This location is not suitable for you." if location is not valid', () => {
            const city = 'Asenovgrad';
            const transport = true;
            const expected = "This location is not suitable for you.";

            const result = findNewApartment.isGoodLocation(city, transport);

            assert.equal(result, expected);
        });
        it('should return "You can go on home tour!" if location is good and public transport is available', () => {
            const city = 'Plovdiv';
            const transport = true;
            const expected = "You can go on home tour!";

            const result = findNewApartment.isGoodLocation(city, transport);

            assert.equal(result, expected);
        });
        it('should return "There is no public transport in area." if location is good but public transport is unavailable', () => {
            const city = 'Plovdiv';
            const transport = false;
            const expected = "There is no public transport in area.";

            const result = findNewApartment.isGoodLocation(city, transport);

            assert.equal(result, expected);
        });
    }),
        describe('Test isLargeEnough', () => {
            it('Should return apartments that meet the wanted criteria for minimal square meters', () => {
                const apartments = [30, 40, 50, 60];
                const minimalSquareMeters = 45;
                const expected = "50, 60";

                const result = findNewApartment.isLargeEnough(apartments, minimalSquareMeters);

                assert.equal(result, expected);
            });

            it('Should throw error on invalid input', () => {
                assert.throws(() => findNewApartment.isLargeEnough([20, 30, 40], 'Dvaise' ), "Invalid input!");
                assert.throws(() => findNewApartment.isLargeEnough("apartment", 20 ), "Invalid input!");
                assert.throws(() => findNewApartment.isLargeEnough([20, 30, 40], undefined ), "Invalid input!");
                assert.throws(() => findNewApartment.isLargeEnough([20, 30, 40], null ), "Invalid input!");
                assert.throws(() => findNewApartment.isLargeEnough(null, 30 ), "Invalid input!");
                assert.throws(() => findNewApartment.isLargeEnough(undefined, 30 ), "Invalid input!");
                assert.throws(() => findNewApartment.isLargeEnough(true, 30 ), "Invalid input!");
            });
        }),
        describe('isItAffordable', () => {
            it('should throw an error on invalid input', () => {
                assert.throws(() => findNewApartment.isItAffordable("text", 1200), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable("text", 'text'), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable("text", null), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable(["some"], 1200), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable("text", undefined), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable(0, 0), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable(-50, 10), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable(10, -20), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable(1200, "text"), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable(1200, undefined), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable(1200, null), "Invalid input!");
                assert.throws(() => findNewApartment.isItAffordable(1200, [1,2]), "Invalid input!");
            });
            it('should not be affordable if price is greater than budget', () => {
                const budget = 1000;
                const price = 1500;
                const expected = "You don't have enough money for this house!";

                const result = findNewApartment.isItAffordable(price, budget);

                assert.equal(result, expected);

            });
            it('should be affordable if price is equal to or less than budget', () => {
                const budget = 1500;
                const price = 1000;
                const expected = "You can afford this home!";

                const result = findNewApartment.isItAffordable(price, budget);

                assert.equal(result, expected);
            });
        })
})


