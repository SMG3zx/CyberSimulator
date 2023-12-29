namespace NetworkSimulator.OSI_Layers;

/*
 * This layer provides error-free transmission of data across a physical link, using technologies such as error detection and correction.
 * The layer focuses on local delivery of frames between nodes on the same network segment and uses protocols such as CSMA/CD (Carrier Sense Multiple Access with Collision Detection) in ethernet networks
 * along with the Binary Exponential Backoff Algorithm to prevent further collisions alongside preventing the problem from happening in the first place.
 * Popular data link protocols include ethernet, IEEE 802.11 (Wi-Fi), ATM (Asynchronous Transfer Mode), and frame relay.
 */
public interface ILayer2DataLink
{
    
}