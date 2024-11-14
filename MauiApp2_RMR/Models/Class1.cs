using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MauiApp2_RMR.Models
{
    public class CoordinatesNovi
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }

    public class AddressNovi
    {
        [JsonProperty("address")]
        public string StreetAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("coordinates")]
        public CoordinatesNovi Coordinates { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class HairNovi
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class BankNovi
    {
        [JsonProperty("cardExpire")]
        public string CardExpire { get; set; }

        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }
    }

    public class CompanyNovi
    {
        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("address")]
        public AddressNovi Address { get; set; }
    }

    public class CryptoNovi
    {
        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("wallet")]
        public string Wallet { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }
    }

    public class UporabnikNovi
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("maidenName")]
        public string MaidenName { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("bloodGroup")]
        public string BloodGroup { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("eyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("hair")]
        public HairNovi Hair { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("address")]
        public AddressNovi Address { get; set; }

        [JsonProperty("macAddress")]
        public string MacAddress { get; set; }

        [JsonProperty("university")]
        public string University { get; set; }

        [JsonProperty("bank")]
        public BankNovi Bank { get; set; }

        [JsonProperty("company")]
        public CompanyNovi Company { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("crypto")]
        public CryptoNovi Crypto { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class UporabnikiWrapperNovi
    {
        [JsonProperty("users")]
        public List<UporabnikNovi> Users { get; set; }
    }
}
