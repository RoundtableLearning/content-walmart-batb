using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTL.Atlas;

public class SceneSequenceExample : SequenceController
{
    private void Start()
    {
        InitStateMachine();
        AddState(new FadeInSequence(1f));
        AddState(new PlayVOSequence("BATB_NARRATOR_000_00", true)); // vo: Hello, and welcome to Brilliant at the Basics in VR! This experience will show you how all the parts of Sam's Club work together to make a great shopping experience.
        AddState(new PlayVOSequence("BATB_NARRATOR_001_00", true)); // vo: Good Neighbor Standards start here, outside the building. Make sure that the parking lot, landscaping, and building exterior are clean and free of garbage.
        AddState(new PlayVOSequence("BATB_NARRATOR_002_00", true)); // vo: Good Neighbor Standards also mean helping our members when they need it. This member is struggling to load a TV. Select the member to teleport to them.
        AddState(new PlayVOSequence("BATB_NARRATOR_003_00", true)); // vo: Even though you're not clocked in yet, you should still help out the member. You can ask management for a time adjustment after you get inside. Select the TV to help load it into the truck. 
        AddState(new PlayVOSequence("BATB_NARRATOR_004_00", true)); // vo: Nice work! Let's head into the club. Select the building to teleport to the entrance.
        AddState(new PlayVOSequence("BATB_NARRATOR_005_00", true)); // vo: Make sure to keep a lookout for any garbage where it doesn't belong! Select the bottle to throw it away.
        AddState(new PlayVOSequence("BATB_NARRATOR_006_00", true)); // vo: Head inside by selecting the door.
        AddState(new PlayVOSequence("BATB_NARRATOR_007_00", true)); // vo: The entrance and first 100 feet of a Sam's Club are critical when it comes to setting standards and meeting our members' expectations. 
        AddState(new PlayVOSequence("BATB_NARRATOR_008_00", true)); // vo: Carts must be clean and trash free; the space must be clean and filled with friendly associates; all of the TVs need to be on and playing the same feed; all merchandise must be orderly, properly labeled, and well-stocked; the member service desk must be clean and organized; and the entrance windows need to be clean and streak free. 
        AddState(new PlayVOSequence("BATB_NARRATOR_009_00", true)); // vo: Speaking of which, it looks like a few things need help around here. Select the problem items to fix them.
        AddState(new PlayVOSequence("BATB_NARRATOR_010_00", true)); // vo: Great job! Let's keep moving. Select the arrow to head into the club.
        AddState(new PlayVOSequence("BATB_NARRATOR_011_00", true)); // vo: Uh-oh, it looks like this item is all out of stock. Let's have another associate help us put something new there.
        AddState(new PlayVOSequence("BATB_NARRATOR_012_00", true)); // vo: Restocking using the 'Perfect Pallet' method follows a handful of steps. First, remove the old pallet.
        AddState(new PlayVOSequence("BATB_NARRATOR_013_00", true)); // vo: Then, cut the plastic wrapping off the pallet and trim the cardboard at the bottom if needed.
        AddState(new PlayVOSequence("BATB_NARRATOR_014_00", true)); // vo: Next, use a broom to sweep out and clean the pallet slot.
        AddState(new PlayVOSequence("BATB_NARRATOR_015_00", true)); // vo: Now, load the new pallet into the slot, with the product facing out. Then, 'bump' the items on the new pallet to make sure they are flush and straight with the front edge.
        AddState(new PlayVOSequence("BATB_NARRATOR_016_00", true)); // vo: Lastly, print out a sign and hang it above the center of the pallet, flush with the red bar on the rack, then place a product display on the rack above the sign.
        AddState(new PlayVOSequence("BATB_NARRATOR_017_00", true)); // vo: Nice, this product is now good to go. Thanks for your help!
        AddState(new PlayVOSequence("BATB_NARRATOR_018_00", true)); // vo: Before we move on, there are a few signs nearby that are crooked. Select them to set them straight.
        AddState(new PlayVOSequence("BATB_NARRATOR_019_00", true)); // vo: Good! Let's keep moving. Select the arrow to head to the back of the club.
        AddState(new PlayVOSequence("BATB_NARRATOR_020_00", true)); // vo: The Bakery, Produce and Floral, Meat and Seafood, Cafe, & Freezer Cooler Dairy & Deli departments make up the FRESH areas of the club. These areas are critical because they provide the most value to our members who visit frequently. As such, quality and sanitation are paramount to both safety and success. In addition, staple products should be available regardless of the time of day.
        AddState(new PlayVOSequence("BATB_NARRATOR_025_00", true)); // vo: First, let's look at Presentation, which means that areas are clean and well-stocked with products.
        AddState(new PlayVOSequence("BATB_NARRATOR_026_00", true)); // vo: It looks like this bread display is missing some product. Select the empty space to fill it back up.
        AddState(new PlayVOSequence("BATB_NARRATOR_027_00", true)); // vo: Next, let's look at Quality, which focuses on making sure that our FRESH products are ready to eat. Select the meat section to head over there.
        AddState(new PlayVOSequence("BATB_NARRATOR_028_00", true)); // vo: Uh-oh, it looks like this meat has expired. We can't let expired, brown, or leaking items be sold to members, so select the meat to place it on the counter for a meat department associate to take and process.
        AddState(new PlayVOSequence("BATB_NARRATOR_029_00", true)); // vo: Nice! People and Process work behind the scenes for our members, making sure that associates have a safe and clean workspace to prepare FRESH items. It means that equipment like the meat bandsaw require further training and safety protocols for clean and safe usage. Let's keep going. Select the arrow to head to the backroom.
        AddState(new PlayVOSequence("BATB_NARRATOR_030_00", true)); // vo: The backroom of a Sam's Club is full of activity, with people and equipment moving items all over the place, making safety a top priority.
        AddState(new PlayVOSequence("BATB_NARRATOR_031_00", true)); // vo: To keep the backroom safe, clean up any empty pallets you find to reduce injury risks. 
        AddState(new PlayVOSequence("BATB_NARRATOR_032_00", true)); // vo: Forklifts have a 10-foot bubble around them called the Red Aone. Anyone not driving the forklift must stay out of the Zed Zone at all times.
        AddState(new PlayVOSequence("BATB_NARRATOR_033_00", true)); // vo: Keep an eye out for any puddles or spills, as these could be a fall hazard.
        AddState(new PlayVOSequence("BATB_NARRATOR_034_00", true)); // vo: And of course, make sure to tidy up the backroom before you leave to set the next shift up for success. 
        AddState(new PlayVOSequence("BATB_NARRATOR_035_00", true)); // vo: Fire exits need 3 feet of clearance to make sure that the door can be opened in an emergency. Select the pallets to unblock the door.
        AddState(new PlayVOSequence("BATB_NARRATOR_036_00", true)); // vo: Great! Let's start heading back to the front of the club. Select the arrow to leave the backroom.
        AddState(new PlayVOSequence("BATB_NARRATOR_037_00", true)); // vo: Uh-oh! It looks like these clothes got all mixed up. Presentation is important when it comes to merchandise, especially with items like clothes, which have multiple colors and sizes.
        AddState(new PlayVOSequence("BATB_NARRATOR_038_00", true)); // vo: Clothes should be organized by type, size, and color, with lightest on the left and darkest on the right. Select the clothes that are out of place to put them where they belong.
        AddState(new PlayVOSequence("BATB_NARRATOR_039_00", true)); // vo: Great work! Let's move on. Select the arrow to head to the checkout area.
        AddState(new PlayVOSequence("BATB_NARRATOR_040_00", true)); // vo: The checkout lanes are where our membership experience shines, with smiling associates helping members purchase their items and maximize benefits with membership upgrades and credit cards. 
        AddState(new PlayVOSequence("BATB_NARRATOR_041_00", true)); // vo: To provide the best experience, the checkout lanes should be clean, clutter free, without homemade signs, and fully stocked with cups. 
        AddState(new PlayVOSequence("BATB_NARRATOR_042_00", true)); // vo: It looks like there's a few extra boxes here and a dispenser is missing cups. Select each item to set things right.
        AddState(new PlayVOSequence("BATB_NARRATOR_043_00", true)); // vo: Great! Let's head over to the cafe, select the arrow to go there.
        AddState(new PlayVOSequence("BATB_NARRATOR_044_00", true)); // vo: The cafe is the 'face' of the club, where most of our members will visit before leaving. Since people eat here, service and cleanliness are critical. Everyone must do their part to keep the cafe up and running.
        AddState(new PlayVOSequence("BATB_NARRATOR_045_00", true)); // vo: Since a lot of people come through here, this area regularly needs attention. Take a look around and select anything that needs cleaned up or thrown away.
        AddState(new PlayVOSequence("BATB_NARRATOR_046_00", true)); // vo: Nice work, the cafe is looking great! The last place we'll visit is fulfillment. Select the arrow to head there now.
        AddState(new PlayVOSequence("BATB_NARRATOR_047_00", true)); // vo: The fulfillment area is where we stage items to be picked up by, or delivered to, members. Activity in this area has exploded in recent years, with more and more members wanting to take advantage of the service.
        AddState(new PlayVOSequence("BATB_NARRATOR_048_00", true)); // vo: To keep things running smoothly and ensure it's easy for members to receive their items, it's important to remember to always be friendly and keep the area clean to prevent delays and mistakes.
        AddState(new PlayVOSequence("BATB_NARRATOR_049_00", true)); // vo: It gets super busy around here, so let's see how we can help. Select anything that needs to be cleaned up or put away.
        AddState(new PlayVOSequence("BATB_NARRATOR_050_00", true)); // vo: That's all for this area! Select the arrow to head back outside.
        AddState(new PlayVOSequence("BATB_NARRATOR_051_00", true)); // vo: Excellent work today! Now you know the basics of making the Sam's Club experience great for our members and associates. Here are a few things to keep in mind as you head back into the real world:
        AddState(new PlayVOSequence("BATB_NARRATOR_052_00", true)); // vo: First and foremost, our members rely on us to make Sam's Club a safe, friendly, and reliable experience.
        AddState(new PlayVOSequence("BATB_NARRATOR_053_00", true)); // vo: Keeping areas clean and clutter-free will prevent issues or injuries and make members happy.
        AddState(new PlayVOSequence("BATB_NARRATOR_054_00", true)); // vo: And lastly, it takes all of us to make things work, so do your part and don't be afraid to ask for help! 
        AddState(new PlayVOSequence("BATB_NARRATOR_055_00", true)); // vo: Nice job! If you'd like to go back and check out any of the Club's areas, select 'Club Zones.' If not, select 'Main Menu' to leave the experience.

        AddState(new EndState());
        FinishStateMachine();
        RunStateMachine();
    }
}
