C# .NET 4.6 / .NET Standard Port of the IOTA lib (https://github.com/iotaledger/), build to fit into Clean Architecture (see below).

![cleanarch](http://i.imgur.com/WkBAATy.png)

More information:
http://blog.8thlight.com/uncle-bob/2012/08/13/the-clean-architecture.html

# Build Status 

<img src="https://felandilprojects.visualstudio.com/_apis/public/build/definitions/8112d254-cde8-46da-add3-75cab5fb802c/1/badge"/>

## About

This project was set up a little different from most (except the python one) IOTA libs, since Clean Architecture enables you to follow the SOLID principles (https://en.wikipedia.org/wiki/SOLID_(object-oriented_design) pretty easy.

## Supported Operations

Next Up: 

	**Multisig**
	**Curl Performance**
	**Flash Channels**


| Operation (Core)				 | Supported       | Operation (Extended)			  | Supported       | 
| ------------------------------ | --------------- | -------------------------------- | --------------- | 
| getNeighbors					 | Yes		       | broadcastAndStoreTransaction     | Yes		        |
| getNodeInfo					 | Yes             | getAccountData				      | Yes		        |
| addNeighbors					 | Yes			   | getBundle					      | Yes		        |
| removeNeighbors				 | Yes			   | getInputs					      | Yes		        |
| getTips						 | Yes             | getLatestInclusion			      | Yes             |
| findTransactions				 | Yes	           | getNewAddresses				  | Yes		        |
| getTrytes						 | Yes			   | getTransfers					  | Yes			    |
| getInclusionStates			 | Yes             | prepareTransfers				  | Yes             |
| getBalances					 | Yes    		   | replayBundle					  | Yes			    |
| getTransactionsToApprove		 | Yes             | sendTransfer					  | Yes             |
| attachToTangle				 | Yes             | sendTrytes						  | Yes		        |
| interruptAttachingToTangle	 | Yes             |
| broadcastTransactions			 | Yes			   |
| storeTransactions				 | Yes			   |
| wereAddressesSpentFrom	     | Yes			   |
| checkConsistency				 | Yes			   |

In addition to all operations you can also do the Proof of Work locally via CPU. Please note that this is very time consuming and might not be feasible for large bundles.

## Documentation

https://tangle-net.readthedocs.io/en/latest/

## Contributing

If you want to contribute, please feel free to grab an issue or implement more features.

## Encryption

The library uses the C# Port of Bouncy Castle (http://www.bouncycastle.org/csharp/).

## NuGet

### Tangle.Net
.NET 4.6.1: https://www.nuget.org/packages/Tangle.Net <br>
.NET Standard 2.0: https://www.nuget.org/packages/Tangle.Net.Standard/

### Tangle.Net.Mam
.NET 4.6.1: https://www.nuget.org/packages/Tangle.Net.Mam/ <br>
.NET Standard 2.0: https://www.nuget.org/packages/Tangle.Net.Standard.Mam/

## Getting started

https://tangle-net.readthedocs.io/en/latest/getting_started.html

