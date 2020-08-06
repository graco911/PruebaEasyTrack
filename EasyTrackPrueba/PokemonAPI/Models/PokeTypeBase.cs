using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokemonAPI.Models
{
	public class PokeTypeBase
	{
		[JsonProperty("abilities")]
		public List<Ability> Abilities { get; set; }
		[JsonProperty("base_experience")]
		public int BaseExperience { get; set; }
		[JsonProperty("forms")]
		public List<Form> Forms { get; set; }
		[JsonProperty("game_indices")]
		public List<GameIndices> GameIndices { get; set; }
		[JsonProperty("height")]
		public int Height { get; set; }
		[JsonProperty("held_items")]
		public List<object> HeldItems { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("is_default")]
		public bool IsDefault { get; set; }
		[JsonProperty("location_area_encounters")]
		public string LocationAreaEncounters { get; set; }
		[JsonProperty("moves")]
		public List<Move> Moves { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("species")]
		public Species Species { get; set; }
		[JsonProperty("sprites")]
		public Sprites Sprites { get; set; }
		[JsonProperty("stats")]
		public List<Stat> Stats { get; set; }
		[JsonProperty("types")]
		public List<Type2> Types { get; set; }
		[JsonProperty("weight")]
		public int Weight { get; set; }
	}
	public class Ability
	{
		[JsonProperty("ability")]
		public Ability1 Ability1 { get; set; }
		[JsonProperty("is_hidden")]
		public bool IsHidden { get; set; }
		[JsonProperty("slot")]
		public int Slot { get; set; }
	}
	public class Ability1
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
	public class Form
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
	public class GameIndices
	{
		[JsonProperty("game_index")]
		public int GameIndex { get; set; }
		[JsonProperty("version")]
		public Version Version { get; set; }
	}
	public class Version
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
	public class Move
	{
		[JsonProperty("move")]
		public Move1 Move1 { get; set; }
		[JsonProperty("version_group_details")]
		public List<VersionGroupDetails> VersionGroupDetails { get; set; }
	}
	public class Move1
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
	public class VersionGroupDetails
	{
		[JsonProperty("level_learned_at")]
		public int LevelLearnedAt { get; set; }
		[JsonProperty("move_learn_method")]
		public MoveLearnMethod MoveLearnMethod { get; set; }
		[JsonProperty("version_group")]
		public VersionGroup VersionGroup { get; set; }
	}
	public class MoveLearnMethod
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
	public class VersionGroup
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
	public class Species
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
	public class Sprites
	{
		[JsonProperty("back_default")]
		public string BackDefault { get; set; }
		[JsonProperty("back_female")]
		public object BackFemale { get; set; }
		[JsonProperty("back_shiny")]
		public string BackShiny { get; set; }
		[JsonProperty("back_shiny_female")]
		public object BackShinyFemale { get; set; }
		[JsonProperty("front_default")]
		public string FrontDefault { get; set; }
		[JsonProperty("front_female")]
		public object FrontFemale { get; set; }
		[JsonProperty("front_shiny")]
		public string FrontShiny { get; set; }
		[JsonProperty("front_shiny_female")]
		public object FrontShinyFemale { get; set; }
		[JsonProperty("other")]
		public Other Other { get; set; }
		[JsonProperty("versions")]
		public Versions Versions { get; set; }
	}
	public class Other
	{
		[JsonProperty("dream_world")]
		public DreamWorld DreamWorld { get; set; }
	}
	public class DreamWorld
	{
		[JsonProperty("front_default")]
		public string FrontDefault { get; set; }
		[JsonProperty("front_female")]
		public object FrontFemale { get; set; }
	}
	public class Versions
	{
		[JsonProperty("generation-i")]
		public Generation Generation { get; set; }
	}
	public class Generation
	{
		[JsonProperty("red-blue")]
		public RedBlue RedBlue { get; set; }
		[JsonProperty("yellow")]
		public Yellow Yellow { get; set; }
	}
	public class RedBlue
	{
		[JsonProperty("back_default")]
		public string BackDefault { get; set; }
		[JsonProperty("back_gray")]
		public string BackGray { get; set; }
		[JsonProperty("front_default")]
		public string FrontDefault { get; set; }
		[JsonProperty("front_gray")]
		public string FrontGray { get; set; }
	}
	public class Yellow
	{
		[JsonProperty("back_default")]
		public string BackDefault { get; set; }
		[JsonProperty("back_gray")]
		public string BackGray { get; set; }
		[JsonProperty("front_default")]
		public string FrontDefault { get; set; }
		[JsonProperty("front_gray")]
		public string FrontGray { get; set; }
	}
	public class Stat
	{
		[JsonProperty("base_stat")]
		public int BaseStat { get; set; }
		[JsonProperty("effort")]
		public int Effort { get; set; }
		[JsonProperty("stat")]
		public Stat1 Stat1 { get; set; }
	}
	public class Stat1
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
	[JsonObject("Type")]
	public class Type2
	{
		[JsonProperty("slot")]
		public int Slot { get; set; }
		[JsonProperty("type")]
		public Type1 Type1 { get; set; }
	}
	public class Type1
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
