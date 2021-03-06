#import <Foundation/Foundation.h>
#import <CoreData/CoreData.h>

#import "DRCTSGetMessagesDataManagedObjectBuilder.h"
#import "DRCTSGetMessagesMetaManagedObjectBuilder.h"

#import "DRCTSGetMessageManagedObject.h"
#import "DRCTSGetMessage.h"

/**
* directus.io
* API for directus.io
*
* OpenAPI spec version: 1.1
* 
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/


@interface DRCTSGetMessageManagedObjectBuilder : NSObject

@property (nonatomic, strong) DRCTSGetMessagesMetaManagedObjectBuilder * metaBuilder;
@property (nonatomic, strong) DRCTSGetMessagesDataManagedObjectBuilder * dataBuilder;


-(DRCTSGetMessageManagedObject*)createNewDRCTSGetMessageManagedObjectInContext:(NSManagedObjectContext*)context;

-(DRCTSGetMessageManagedObject*)DRCTSGetMessageManagedObjectFromDRCTSGetMessage:(DRCTSGetMessage*)object context:(NSManagedObjectContext*)context;

-(void)updateDRCTSGetMessageManagedObject:(DRCTSGetMessageManagedObject*)object withDRCTSGetMessage:(DRCTSGetMessage*)object2;

-(DRCTSGetMessage*)DRCTSGetMessageFromDRCTSGetMessageManagedObject:(DRCTSGetMessageManagedObject*)obj;

-(void)updateDRCTSGetMessage:(DRCTSGetMessage*)object withDRCTSGetMessageManagedObject:(DRCTSGetMessageManagedObject*)object2;

@end
