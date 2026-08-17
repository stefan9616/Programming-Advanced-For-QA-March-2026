import { chooseYourCar } from '../chooseYourCar.js'
import { describe } from 'mocha'
import { expect, assert } from 'chai';

describe('Test chooseYourCar', () => {
    describe('choosingType', () => {
        it('should throw an error on invalid input', () => {

            assert.throw(() => chooseYourCar.choosingType('Sedan', 'Black', 1850), `Invalid Year!`);
            assert.throw(() => chooseYourCar.choosingType('Sedan', 'Black', 2026), `Invalid Year!`);
            assert.throw(() => chooseYourCar.choosingType("SportWagon", "Blue", 2020)),("This type of car is not what you are looking for.")

        });
        it('should meet requirments for a car', () => {
            const type = "Sedan";
            const color = "black"
            const year = 2015;

            const expected = 'This black Sedan meets the requirements, that you have.'

            const result = chooseYourCar.choosingType(type, color, year);

            assert.equal(result, expected);


        });
        it('should not meet requirments for a car', () => {
           let type = 'Sedan'
            let color = 'Blue'
            let year = 2018
            let expectedMessage = `This ${color} ${type} meets the requirements, that you have.`

            // Act
            let result = chooseYourCar.choosingType(type, color, year)

            // Assert
            expect(result).to.equal(expectedMessage)
            // year 2010
            expect(chooseYourCar.choosingType(type, color, 2010)).to.equal(expectedMessage)
            
        });
    });

    describe('brandName', () => {
        it('should throw an error on invalid input', () => {
            assert.throw(() => chooseYourCar.brandName('Audi', 2), "Invalid Information!");
            assert.throw(() => chooseYourCar.brandName(["Audi", 'Tesla', 'BMW'], 'dve'), "Invalid Information!");
            assert.throw(() => chooseYourCar.brandName(["Audi", 'Tesla', 'BMW'], 5), "Invalid Information!");
            assert.throw(() => chooseYourCar.brandName(["Audi", 'Tesla', 'BMW'], -2), "Invalid Information!");
            assert.throw(() => chooseYourCar.brandName(undefined, 5), "Invalid Information!");
            assert.throw(() => chooseYourCar.brandName(null, 5), "Invalid Information!");
            assert.throw(() => chooseYourCar.brandName(['Audi', 'Tesla', 'BMW'], null), "Invalid Information!");
            assert.throw(() => chooseYourCar.brandName(["Audi", 'Tesla', 'BMW'], undefined), "Invalid Information!");
        });

        it('should return the correct brands', () => {
            const brands = ["Audi", 'Tesla', 'BMW'];
            const brandIndex = 2;

            const expected = 'Audi, Tesla'

            const result = chooseYourCar.brandName(brands, brandIndex);

            assert.equal(result, expected);
        });
    });

    describe('carFuelConsumption', () => {
        it('should throw an error on invalid input', () => {
           assert.throw(() => chooseYourCar.carFuelConsumption('pet', 100));
           assert.throw(() => chooseYourCar.carFuelConsumption(0, 100));
           assert.throw(() => chooseYourCar.carFuelConsumption(-50, 100));
           assert.throw(() => chooseYourCar.carFuelConsumption([], 100));
           assert.throw(() => chooseYourCar.carFuelConsumption(null, 100));
           assert.throw(() => chooseYourCar.carFuelConsumption(undefined, 100));
           assert.throw(() => chooseYourCar.carFuelConsumption(100, 0));
           assert.throw(() => chooseYourCar.carFuelConsumption(100, -50));
           assert.throw(() => chooseYourCar.carFuelConsumption(100, 'pet'));
           assert.throw(() => chooseYourCar.carFuelConsumption(100, null));
           assert.throw(() => chooseYourCar.carFuelConsumption(100, undefined));
           assert.throw(() => chooseYourCar.carFuelConsumption(100, []));
        });

        it('should return message for an efficient car', () => {
            const distance = 200;
            const fuel = 12;

            const expected = 'The car is efficient enough, it burns 6.00 liters/100 km.'

            const result = chooseYourCar.carFuelConsumption(distance, fuel);

            assert.equal(result, expected);

        });
         it('should return message for an efficient car', () => {
            const distance = 100;
            const fuel = 7;

            const expected = 'The car is efficient enough, it burns 7.00 liters/100 km.'

            const result = chooseYourCar.carFuelConsumption(distance, fuel);

            assert.equal(result, expected);

        });

        it('should return message for an non efficient car', () => {
            const distance = 200;
            const fuel = 20;

            const expected = 'The car burns too much fuel - 10.00 liters!'

            const result = chooseYourCar.carFuelConsumption(distance, fuel);

            assert.equal(result, expected);
        });
    });
});